using System.Collections.Generic;
using System.IO;
using InstaDev.Interfaces;

namespace InstaDev.Models
{
    public class Post : /* aqui deveria vir uma super classe que eu não sei qual é*/ IFeed
    {

        public int idImagem { get; set; }
        public string imagem { get; set; }
        public string legenda { get; set; }
        public int idUsuario { get; set; }
        public int likes { get; set; }
        private const string PATH = "Feedbase/Post.csv";


        //Metodo construtor
        public Post()
        {
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
        public List<string> ReadAllLinesCSV(string path){
            List<string> linhas = new List<string>();

            //using
            using (StreamReader file = new StreamReader(path))
            {
                string linha;
                while ((linha = file.ReadLine()) !=null)
                {
                    linhas.Add(linha);
                }

            }

            return linhas; 
        }

        public void RewriteCSV(string path, List<string> linhas){

            using (StreamWriter output = new StreamWriter(path))
            {
                foreach (var item in linhas)
                {
                    output.Write( item + '\n' );
                }
            }

        }


        public string Prepare(Post e)
        {
            return $"{e.idImagem};{e.imagem};{e.legenda}";
        }


        //METODOS CRUD
        public void Create(Post e)
        {
            // throw new System.NotImplementedException();

            string[] linhas = { Prepare(e) };
            File.AppendAllLines(PATH, linhas);


        }

        public List<Post> ReadAll()
        {
            List<Post> post = new List<Post>();

            //ler todas as Linhas csv
            string[] linhas = File.ReadAllLines(PATH);

            //Percorrwr as linhas e adicionar cada objeto
            foreach (var item in linhas)
            {
                //Dividir cada elemento no csv
                string[] linha = item.Split(";");

                //Criar objeto Post
                Post pub = new Post();

                //Separar cada indice de sua classe
                pub.idImagem = int.Parse(linha[0]);
                pub.imagem = linha[1];
                pub.legenda = linha[2];

                //adicionar publicação na lista de Publicações
                post.Add(pub);

                

            }


            return post;
        }

        public void Update(Post e)
        {   
            //lemos todas a linhas para localizar o item a ser motificado
            List<string> linhas = ReadAllLinesCSV(PATH);

            //Removemos a linha que tem a legenda a ser alterada
            linhas.RemoveAll(x => x.Split(";")[0] == e.idImagem.ToString());

            //adiconamos uma nova linha "alterada" no final do mesmo codigo
            linhas.Add(Prepare(e));

            //Reescrevemos e Salvamos as alterações
            RewriteCSV(PATH, linhas);
        }



        public void Delete(Post idPub)
        {
            //lemos todas a linhas para localizar o item a ser motificado
            List<string> linhas = ReadAllLinesCSV(PATH);

            //Removemos a linha que tem a legenda a ser alterada
            linhas.RemoveAll(x => x.Split(";")[0] == idImagem.ToString());       

            //Reescrevemos e Salvamos as alterações
            RewriteCSV(PATH, linhas);
        }
    }
}