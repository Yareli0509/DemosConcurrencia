using System.Drawing.Text;

namespace DemoConcurrencia
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _Cts;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSecuencial_Click(object sender, EventArgs e)
        {
            ActualizarResultado("Iniciando proceso secuencial...!");
            for (int i = 0; i < 5; i++)
            {//Sleep: Detiene el procesamiento
                Thread.Sleep(2000); //Carga la segunda linea después de cada 2 segundos
                ActualizarResultado($"Actividad - paso {i + 1}");
            }

            ActualizarResultado("Fin del proceso secuencial!");
        }

        private void ActualizarResultado(string mensaje)
        {
            txtResultado.AppendText($"{DateTime.Now:HH:mm:ss}:{mensaje}{Environment.NewLine}");
        }

        private void btnHilo_Click(object sender, EventArgs e)
        {
            _Cts = new CancellationTokenSource();
            var token = _Cts.Token;
            //thread: Es hilo
            //Thread: Permite crear hilos
            Thread hilo1 = new Thread(() =>
            {
                try
                {
                    ActualizarResultado($"Iniciar nuevo Thread {Thread.CurrentThread.ManagedThreadId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();
                        Thread.Sleep(2000);
                        ActualizarResultado($"Thread {Thread.CurrentThread.ManagedThreadId} terminado.");
                    }
                    ActualizarResultado($"Thread {Thread.CurrentThread.ManagedThreadId} terminado.");
                }
                catch (OperationCanceledException)
                {


                    ActualizarResultado(" Actualizar Hilo Cancelado");
                }
            });
            hilo1.Start();
        }

        private void btnTarea_Click(object sender, EventArgs e)
        {
            _Cts = new CancellationTokenSource();
            var token = _Cts.Token;
            try
            {
                ActualizarResultado("Iniciando Resultado...");
                Task.Run(() =>
                {
                    Thread.Sleep(5000);
                });
                ActualizarResultado("Resultado completada");
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _Cts.Cancel();
        }
    }
}
