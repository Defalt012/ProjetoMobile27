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

            Conexao.Execute("CREATE TABLE IF NOT EXISTS Login (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE" +
                ",Nome TEXT (300) NOT NULL," +
                " Usuario TEXT (500) NOT NULL UNIQUE," +
                " Email TEXT (300) NOT NULL UNIQUE," +
                " Senha TEXT (255) NOT NULL," +
                " CEP INTEGER (8) NOT NULL)");

            
            

            InitializeComponent();

            MainPage = new NavigationPage  (new MainPage());
            NavigationPage.SetHasNavigationBar(this, false);
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
