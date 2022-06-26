string opcao="";

do

try
{

Menu();

Console.Write("\nSelecione a opção desejada:");
opcao = Console.ReadLine()!;


while(opcao != "0" && opcao !="1" && opcao !="2" && opcao !="3"  && opcao !="4" && opcao !="5" && opcao !="6" && opcao !="7" && opcao !="8" && opcao !="9" && opcao !="10")
{
    throw new ArgumentException();
}


switch (opcao)
{
  //****CALCULA SOMA****
  case "1" :

  soma();

     break;
  
  //****CALCULA SUBTRAÇÃO****
  case "2":

  subtracacao();

     break;
     
  //****CALCULA MULTIPLICAÇÃO****  
  case "3":

  multiplicacao();
     
     break;
  
  //****CALCULA DIVISÃO**** 
  case "4":

  divisao();
     
     break;

   //****CALCULA EXPONENCIACAO***
  case "5":

  exponenciacao();

     break;
  
  //***CALCULA RADIAÇÃO***
  case "6":

  raiz();

      break;
  //***CALCULA SENO***
  case "7":

  seno();

      break;

  //****CALCULA COSENO***
  case "8":

  coseno();

      break;
  //***CALCULA TANGENTE***
  case "9":

  tangente();

      break;
  
  case "10":

  sobre();

      break;

}

}

catch(FormatException)
{

  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("Fotmato inválido! Digite um número!");
  Console.ResetColor();
  Console.WriteLine("Pressione uma tecla para retornar ao menu inicial");
  Console.ReadKey();

} 
catch(OverflowException)
{

  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("Formato de número inválido!");
  Console.ResetColor();
  Console.WriteLine("Pressione uma tecla para retornar ao menu inicial");
  Console.ReadKey();


}
catch (DivideByZeroException)
{

  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("Não é possível dividir por zero!");
  Console.ResetColor();
  Console.WriteLine("Pressione uma tecla para retornar ao menu inicial");
  Console.ReadKey();
  Console.ReadKey();

}
catch(ArgumentException)
{

  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("\nValor digitado inválido. Digite uma das opções informadas á cima.");
  Console.ResetColor();
  Console.WriteLine("\nPressione uma tecla para retornar ao menu inicial");
  Console.ReadKey();

}

while ( opcao != "0" );
{

  Console.ForegroundColor = ConsoleColor.Blue;
  Console.WriteLine("\nObrigado por utilizar nosso programa! :)") ;
  Console.ResetColor();
  Environment.Exit(0);
  
}


static void soma()
{
  Console.WriteLine("\nVocê selecionou soma");
     
  double soma, A, B;
    
  Console.WriteLine("\nDigite os valores para A + B :");
   
  Console.Write("A =");
  A = Convert.ToDouble(Console.ReadLine()!);
   
  Console.Write("B =");
  B = Convert.ToDouble(Console.ReadLine()!);

  soma = A + B;

  Console.WriteLine($"\nResultado da soma: {A} + {B} = {soma}");

  Console.WriteLine("\nPressione uma tecla para  retornar ao menu principal");
  Console.ReadKey();

}

static void subtracacao()
{
double subtracao, A, B; 

 Console.WriteLine("\nVocê selecionou subtração");

 Console.WriteLine("\nDigite os valores para A - B :");
 
 Console.Write("A =");
 A = Convert.ToDouble(Console.ReadLine()!);
  
 Console.Write("B =");
 B = Convert.ToDouble(Console.ReadLine()!);
 
 subtracao = A - B;
 
 Console.WriteLine($"\nResultado da subtracao: {A} - {B} = {subtracao}");

  Console.WriteLine("\nPressione uma tecla para  retornar ao menu principal");
  Console.ReadKey();

}

static void multiplicacao()
{
  double multiplicacao, A, B;

  Console.WriteLine("\nVocê selecionou multiplicação");

  Console.WriteLine("\nDigite os valores para A * B :");
  
  Console.Write("A =");
  A = Convert.ToDouble(Console.ReadLine()!);
   
  Console.Write("B =");
  B = Convert.ToDouble(Console.ReadLine()!);
  
  multiplicacao = A * B;
  
  Console.WriteLine($"\nResultado da multiplicação: {A} X {B} = {multiplicacao}");
  
  Console.WriteLine("\nPressione uma tecla para  retornar ao menu principal");
  Console.ReadKey();

}

static void divisao()
{
  double divisao, dividendo, divisor;

  Console.WriteLine("\nVocê selecionou Divisão");
  
  Console.WriteLine("\nDigite os valores para o dividendo e o divisor:");
  
  Console.Write("Dividendo =");
  dividendo = Convert.ToDouble(Console.ReadLine()!);
   
  Console.Write("Divisor =");
  divisor = Convert.ToDouble(Console.ReadLine()!);

while ( divisor == 0)
{

  throw new DivideByZeroException();

}
  
 divisao = dividendo - divisor;
  
 Console.WriteLine($"\nResultado da divisão: {dividendo} / {divisor} = {divisao}");

 Console.WriteLine("\nPressione uma tecla para  retornar ao menu principal");
 Console.ReadKey();

}

static void exponenciacao()
{
  double numeroBase , expoente , potencia;
  
  Console.WriteLine("\nVocê selecionou Exponenciação");
  
  Console.WriteLine("\nDigite os valores para o expoente e a base:");

  Console.Write("A :");
  numeroBase = Convert.ToDouble(Console.ReadLine()!);

  Console.Write("Número elevado:");
  expoente = Convert.ToDouble(Console.ReadLine()!);

  potencia = Math.Pow(numeroBase,expoente);

  Console.WriteLine($"\nResultado da exponênciação: {potencia} ");

  Console.WriteLine("\nPressione uma tecla para  retornar ao menu principal");
  Console.ReadKey();

}

static void raiz()
{
  double numero, radiciacao;

  Console.WriteLine("\nVocê selecionou Raiz Quadrada");
  
  Console.Write("\nDigite um número:");
  numero = Convert.ToDouble(Console.ReadLine()!);

  radiciacao = Math.Sqrt(numero);

  Console.WriteLine($"\nRaiz quadrada de {numero} é: {radiciacao:N2}");

  Console.WriteLine("\nPressione uma tecla para  retornar ao menu principal");
  Console.ReadKey();

}

static void seno()
{
  double valorGraus, seno;
  double pi = Math.PI;  

  Console.WriteLine("\nVocê selecionou Seno");

  Console.Write("\nDigite o valor em graus que deseja calcular:");
  valorGraus = Convert.ToDouble(Console.ReadLine()!);

  seno = Math.Sin(valorGraus * pi / 180);

  Console.WriteLine($"\nO valor do seno de {valorGraus}° é: {seno:N2}");
  
  Console.WriteLine("\nPressione uma tecla para  retornar ao menu principal");
  Console.ReadKey();

}

static void coseno()
{
  double valorGraus , coseno;
  double pi = Math.PI; 

  Console.WriteLine("\nVocê selecionou Coseno");
 
  Console.Write("\nDigite o valor em graus que deseja calcular:");
  valorGraus = Convert.ToDouble(Console.ReadLine()!);

  coseno =  Math.Cos(valorGraus * pi / 180);

  Console.WriteLine($"\nO valor do Coseno de {valorGraus}° é: {coseno:N2}");
  
  Console.WriteLine("\nPressione uma tecla para  retornar ao menu principal");
  Console.ReadKey();

}

static void tangente()
{
  double valorGraus, tangente;
  double pi = Math.PI;  

  Console.WriteLine("\nVocê selecionou Tangente");

  Console.Write("\nDigite o valor em graus que deseja calcular:");
  valorGraus = Convert.ToDouble(Console.ReadLine()!);

  tangente = Math.Tan(valorGraus * pi / 180);

  Console.WriteLine($"\nO valor da Tangente de {valorGraus}° é: {tangente:N2}");
  
  Console.WriteLine("\nPressione uma tecla para  retornar ao menu principal");
  Console.ReadKey();

}

static void sobre()
{
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Esse programa foi criado como o projeto final do curso de Desenvolvedor C#, me chamo Anna Beatriz, tenho 18 anos e atualmente estudo na instituação Etec Adolpho Berezim, no curso de técnico em informática.");
Console.WriteLine("Neste curso encontrei a carreira que quero seguir, Desenvolvedora de Software! ");
Console.WriteLine("Acesse o site do projeto pelo link:https://annarodrig.github.io/ProjetoFinal_Calculadora");
Console.WriteLine("Obrigado por utilizar o meu software!");

Console.ResetColor();
  
Console.WriteLine("\nPressione uma tecla para  retornar ao menu principal");
Console.ReadKey();

}

static void Menu()
{

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Blue;

 Console.WriteLine("=========== Calculadora ===============\n");
 
 Console.WriteLine("( 1 ) Soma         ");
 Console.WriteLine("( 2 ) Substração   ");
 Console.WriteLine("( 3 ) Multiplicação");
 Console.WriteLine("( 4 ) Divisão      ");
 Console.WriteLine("( 5 ) Exponenciação");
 Console.WriteLine("( 6 ) Radiciação   ");
 Console.WriteLine("( 7 ) Seno         ");
 Console.WriteLine("( 8 ) Coseno       ");
 Console.WriteLine("( 9 ) Tangente     ");
 Console.WriteLine("( 10 ) Sobre       ");
 Console.WriteLine("( 0 ) Sair         ");

 Console.ResetColor();
}