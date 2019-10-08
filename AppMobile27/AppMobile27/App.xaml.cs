using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PCLExt.FileStorage.Folders;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppMobile27
{
    public partial class App : Application
    {
        public SQLite.SQLiteConnection Conexao { get; private set; }
        public App()
        {
            var Pasta = new LocalRootFolder();
            var Banco = Pasta.CreateFile("BancoX.db", PCLExt.FileStorage.CreationCollisionOption.OpenIfExists);
            Conexao = new SQLite.SQLiteConnection(Banco.Path);

            Conexao.Execute("CREATE TABLE IF NOT EXISTS Login (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE" +
                ", nome TEXT (300) NOT NULL," +
                " usuario TEXT (500) NOT NULL UNIQUE," +
                " email TEXT (300) NOT NULL UNIQUE," +
                " senha TEXT (255) NOT NULL," +
                " cep INTEGER (8) NOT NULL)");

            
            

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
