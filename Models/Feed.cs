using System.IO;

namespace InstaDev.Models
{
    public class Feed
    {
        
        public int idImagem { get; set; }    
        public string  imagem { get; set; }
        public string legenda { get; set; }
        public int idUsuario { get; set; }
        public int likes { get; set; }
        private const string PATH = "Feedbase/Post.svg";


        public Feed(){

            //Criar uma pasta para base de dados das publicações
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //Criar arquivo para a base de dados das publicações

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }














    }
}