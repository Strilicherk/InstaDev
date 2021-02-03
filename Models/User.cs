using System;
using System.Collections.Generic;
using System.IO;
using InstaDev.Interfaces;

namespace InstaDev.Models
{
    public class User:InstaDevBase, IUser
    {
        public int IdUser { get; set; } 
        public string CompleteName { get; set; } 
        public string Photo { get; set; } 
        public DateTime DateOfBirth { get; set; } 
        public int Following { get; set; } 
        public string Email { get; set; } 
        public string UserName { get; set; } 
        public string Password { get; set; } 
        private const string PATH = "Database/register.csv"; 

        public User(){ 
            CreateFolderAndFile(PATH);
        }

        public int IdGenerator(){
            Random idRandom = new Random();
            return idRandom.Next();
}
        
        public string PrepareLinesCSV(User prepareLines){ 
            return $"{prepareLines.Email};{prepareLines.CompleteName};{prepareLines.UserName};{prepareLines.Password}";
        }

        public void Create(User newUser){ 
            string[] dataToLines = {PrepareLinesCSV(newUser)}; 
            File.AppendAllLines(PATH, dataToLines); 
        }

        public List<User> ReadAllItems(){ 
            List<User> users = new List<User>(); 
            string[] infoData = File.ReadAllLines(PATH); 
            
            foreach(var item in infoData){ 
                string[] data = item.Split(";"); 
                
                User user = new User(); 
                
                user.Email = data[0]; 
                user.CompleteName = data[1];
                user.UserName = data[2];
                user.Password = data[3];

                users.Add(user); 
            }

            return users; 
        }

        public void Update(User update){
            List<string> linesUpdate = ReadAllLinesCSV(PATH);
        

            linesUpdate.RemoveAll( x => x.Split(";")[0] == update.IdUser.ToString() ); 
        

            linesUpdate.Add(PrepareLinesCSV(update));


            RewriteCSV(PATH,linesUpdate);
        } 

        public void Delete(int id){
            List<string> linesUpdate = ReadAllLinesCSV(PATH);
        

            linesUpdate.RemoveAll( x => x.Split(";")[0] == id.ToString() ); 
        
            
            RewriteCSV(PATH,linesUpdate);
        } 
    }
}