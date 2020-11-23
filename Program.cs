using System;

namespace Excercicio_dia20
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //Faça um programa que receba o nome e quatro notas de 10 alunos e armazene essas notas em vetores. Calcule e mostre:        
            Console.WriteLine("Exercício do dia 20 para calcular notas de 10 Alunos");
            Console.WriteLine("---------------------");
            
            string[] nomes = new string [10];
            int[] notas1 = new int[10];
            int[] notas2 = new int[10];
            int[] notas3 = new int[10];
            int[] notas4 = new int[10];
            
            float[] media = new float [10];

            int alunosaprovados = 0;
            int alunosreprovados = 0;
            
    
        
            
            for (var contador = 0; contador < 10; contador++)  
            {
                Console.Write("Digite o nome do aluno: ");
                nomes[contador] = Console.ReadLine();

                Console.Write("Digite a primeira nota: ");
                notas1[contador] = int.Parse(Console.ReadLine());

                Console.Write("Digite a segunda nota: ");
                notas2[contador] = int.Parse(Console.ReadLine());

                Console.Write("Digite a terceira nota: ");
                notas3[contador] = int.Parse(Console.ReadLine());

                Console.Write("Digite a quarta nota: ");
                notas4[contador] = int.Parse(Console.ReadLine());
                
                Console.WriteLine(" --------------- ");


             media[contador] = (notas1[contador] + notas2[contador] + notas3[contador] + notas4[contador])/4;
             Console.WriteLine($"A média do aluno {nomes[contador]}: {media[contador]} ");
             if (media[contador] >= 7){
                    alunosaprovados = alunosaprovados + 1;
                    Console.WriteLine($" Aluno(a) {nomes[contador]} está Aprovado(a)!"); 
            }else{
                alunosreprovados = alunosreprovados + 1;
                Console.WriteLine($"Aluno(a) {nomes[contador]} está Reprovado(a)!"); 

            }
            }
                Console.WriteLine(" --------------- ");
           
           
        










        }
    }
} 
