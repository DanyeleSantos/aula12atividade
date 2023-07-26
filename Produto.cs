using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12Atividade
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public string descricao;
        public int quantidade;
        public bool status;

        public void mostra()
        {
            Console.WriteLine($" nome do produto é {nome}\n descrição {descricao}\n o é valor {preco}\n disponível {quantidade}\n em estoque o status é: {status}\n");
        }

        public void desativa()
        {
            quantidade= 0;
            status= false;


        } 

        


       
    }
}
