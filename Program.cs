string opcao="";

do

try
{

Menu();

Console.Write("\nSelecione a opção desejada:");
opcao = Console.ReadLine()!;

while(opcao != "0" && opcao !="1" && opcao !="2" && opcao !="3"  && opcao !="4" && opcao !="5" && opcao !="6" && opcao !="7" && opcao !="8" && opcao !="9")
{
    throw new Exception();
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
  Console.WriteLine("Formato de número inválido!");
  Console.ResetColor();
  Console.ReadKey();

}
catch(Exception)
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
  Console.WriteLine("Você selecionou soma");
     
  double soma, A, B;
    
  Console.WriteLine("Digite os valores para A + B :");
   
  Console.Write("A =");
  A = Convert.ToDouble(Console.ReadLine()!);
   
  Console.Write("B =");
  B = Convert.ToDouble(Console.ReadLine()!);

  soma = A + B;

  Console.WriteLine($"Resultado da soma: {A} + {B} = {soma}");
}

static void subtracacao()
{
double subtracao, A, B; 

 Console.WriteLine("Você selecionou subtração");

 Console.WriteLine("Digite os valores para A - B :");
 
 Console.Write("A =");
 A = Convert.ToDouble(Console.ReadLine()!);
  
 Console.Write("B =");
 B = Convert.ToDouble(Console.ReadLine()!);
 
 subtracao = A - B;
 
 Console.WriteLine($"\nResultado da subtracao: {A} - {B} = {subtracao}");
}

static void multiplicacao()
{
  double multiplicacao, A, B;

  Console.WriteLine("Você selecionou multiplicação");

  Console.WriteLine("Digite os valores para A * B :");
  
  Console.Write("A =");
  A = Convert.ToDouble(Console.ReadLine()!);
   
  Console.Write("B =");
  B = Convert.ToDouble(Console.ReadLine()!);
  
  multiplicacao = A * B;
  
  Console.WriteLine($"\nResultado da multiplicação: {A} X {B} = {multiplicacao}");
}

static void divisao()
{
  double divisao, dividendo, divisor;

  Console.WriteLine("Você selecionou Divisão");
  
  Console.WriteLine("Digite os valores para o dividendo e o divisor:");
  
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
}

static void exponenciacao()
{
  double numeroBase , expoente , potencia;
  
  Console.WriteLine("Você selecionou Exponenciação");
  
  Console.WriteLine("Digite os valores para o expoente e a base:");

  Console.Write("A :");
  numeroBase = Convert.ToDouble(Console.ReadLine()!);

  Console.Write("Número elevado:");
  expoente = Convert.ToDouble(Console.ReadLine()!);

  potencia = Math.Pow(numeroBase,expoente);

  Console.WriteLine($"\nResultado da exponênciação: {potencia} ");
}

static void raiz()
{
  double valorRadiciacao, radiciacao;

  Console.WriteLine("Você selecionou Raiz Quadrada");
  
  Console.Write("\nDigite um número:");
  valorRadiciacao = Convert.ToDouble(Console.ReadLine()!);

  radiciacao = Math.Sqrt(valorRadiciacao);

  Console.WriteLine($"\nResultado da radiciação: {radiciacao:N2}");
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
}

static void Menu()
{
 Console.WriteLine("=========== Calculadora ===============\n");
 
 Console.WriteLine("( 1 ) Soma");
 Console.WriteLine("( 2 ) Substração");
 Console.WriteLine("( 3 ) Multiplicação");
 Console.WriteLine("( 4 ) Divisão");
 Console.WriteLine("( 5 ) Exponenciação");
 Console.WriteLine("( 6 ) Radiciação");
 Console.WriteLine("( 7 ) Seno");
 Console.WriteLine("( 8 ) Coseno");
 Console.WriteLine("( 9 ) Tangente");
 Console.WriteLine("( 0 ) Sair");

}