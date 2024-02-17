int opp, op1, op2, op3, op4;
do
{
    Console.WriteLine("Seleccione una opción: \n1.Conversión de tipos. \n2.Operaciones con tipos de datos. \n3.Uso de char y string. \n4.Uso de tipos de datos numéricos. \n5.Salir ");
    opp = int.Parse(Console.ReadLine());

    switch (opp)
    {
        case 1:
            Console.WriteLine("Seleccione una opción: \n1.Convertir un número entero a decimal. \n2.Convertir un número decimal a flotante. \n3.Convertir un número flotante a entero. \n4.Convertir un caracter a entero. \n5.Convertir un entero a caracter. ");
            op1 = int.Parse(Console.ReadLine());

            switch (op1)
            {
                case 1:
                    Console.WriteLine("Ingrese un número entero: ");
                    int ne = int.Parse(Console.ReadLine());
                    decimal deci = Convert.ToDecimal(ne);
                    Console.WriteLine("El número entero " + ne + ", equivale al decimal " + deci);
                    break;

                case 2:
                    Console.WriteLine("Ingrese un número decimal: ");
                    decimal nd = decimal.Parse(Console.ReadLine());
                    float flo = (float)nd;
                    Console.WriteLine("El número deciaml " + nd + ", equivale al valor flotante: " + flo);
                    break;

                case 3:
                    Console.WriteLine("Ingrese un valor flotante: ");
                    float vf = float.Parse(Console.ReadLine());
                    int ent = (int)vf;
                    Console.WriteLine("El valor flotante " + vf + ", equivale al número entero: " + ent);
                    break;

                case 4:
                    Console.WriteLine("Ingrese un caracter: ");
                    char car = char.Parse(Console.ReadLine());
                    int entr = (int)car;
                    Console.WriteLine("El caracter " + car + ", equivale al número entero: " + entr);

                    break;

                case 5:
                    Console.WriteLine("Ingrese un número entero: ");
                    int nen = int.Parse(Console.ReadLine());
                    char carac = (char)nen;
                    Console.WriteLine("El número entero " + nen + ", equivale al caracter: " + carac);

                    break;

            }
            break;
        case 2:
            Console.WriteLine("Seleccione una opción: \n1.Suma de dos números enteros. \n2.Resta de dos números decimales. \n3.Multiplicación de dos números flotantes. \n4.División de dos números enteros. \n5.Módulo de dos números enteros. ");
            op2 = int.Parse(Console.ReadLine());

            switch (op2)
            {
                case 1:
                    Console.WriteLine("Ingrese el primer número que desea sumar: ");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número que desea sumar: ");
                    int n2 = int.Parse(Console.ReadLine());
                    int s = n1 + n2;
                    Console.WriteLine("El resultado de la suma es de: " + s);
                    break;

                case 2:
                    Console.WriteLine("Ingrese el primer número que desea restar: ");
                    decimal r1 = Decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número que desea restar: ");
                    decimal r2 = Decimal.Parse(Console.ReadLine());
                    decimal r = r1 - r2;
                    Console.WriteLine("El resultado de la resta es de: " + r);
                    break;
                case 3:
                    Console.WriteLine("Ingrese el primer valor float que desea multiplicar: ");
                    float m1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo valor float que desea multiplicar: ");
                    float m2 = float.Parse(Console.ReadLine());
                    float m = m1 * m2;
                    Console.WriteLine("El resultado de la multiplicación es de: " + m);
                    break;
                case 4:
                    Console.WriteLine("Ingrese el primer número que desea dividir: ");
                    int d1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número que desea dividir: ");
                    int d2 = int.Parse(Console.ReadLine());
                    decimal d = d1 / d2;
                    Console.WriteLine("El resultado de la división es de: " + d);
                    break;
                case 5:
                    Console.WriteLine("Ingrese el primer número: ");
                    int mo1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número: ");
                    int mo2 = int.Parse(Console.ReadLine());
                    decimal mo = mo1 % mo2;
                    Console.WriteLine("El resultado de el modulo es de: " + mo);
                    break;
            }
            break;
        case 3:
            Console.WriteLine("Seleccione una opción: \n1.Convertir toda la cadena de texto a mayúsculas. \n2.Convertir toda la cadena de texto a minúsculas. \n3.Imprimir una cadena de texto al revés. \n4.Buscar una palabra en la cadena de texto. \n5.Contar las vocales y las consonantes que contiene la cadena de texto. ");
            op3 = int.Parse(Console.ReadLine());

            switch (op3)
            {
                case 1:
                    Console.WriteLine("Ingrese una cadena de texto: ");
                    string cad1 = Console.ReadLine();
                    string cadmayus = cad1.ToUpper();
                    Console.WriteLine("Resultado: " + cadmayus);
                    break;
                case 2:
                    Console.WriteLine("Ingrese una cadena de texto: ");
                    string cad2 = Console.ReadLine();
                    string cadminus = cad2.ToLower();
                    Console.WriteLine("Resultado: " + cadminus);
                    break;
                case 3:
                    Console.WriteLine("Ingrese una cadena de texto: ");
                    string cad3 = Console.ReadLine();
                    for (int i = cad3.Length - 1; i >= 0; i--)
                    {
                        Console.Write("Resultado: " + cad3[i]);
                    }
                    break;
                case 4:
                    Console.WriteLine("Ingrese una cadena de texto: ");
                    string cad4 = Console.ReadLine();
                    Console.WriteLine("Ingrese la palabra que desea buscar en la cadena de texto:");
                    string pal = Console.ReadLine();
                    if (cad4.Contains(pal))
                    {
                        Console.WriteLine("La palabra " + pal + " fue encontrada en la cadena de texto.");
                    }
                    else
                    {
                        Console.WriteLine("La palabra " + pal + " no fue encontrada en la cadena de texto.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Ingrese una cadena de texto: ");
                    string cad5 = Console.ReadLine();
                    int contvo = 0, contlet = 0, contcons;
                    foreach (char caracter in cad5)
                    {
                        if ("aeiouAEIOU".Contains(caracter))
                        {
                            contvo++;
                        }
                    }
                    foreach (char caracter in cad5)
                    {
                        if (char.IsLetter(caracter))
                        {
                            contlet++;
                        }
                    }
                    contcons = contlet - contvo;
                    Console.WriteLine("El número de letras en la cadena texto es de: " + contlet);
                    Console.WriteLine("El número de vocales en la cadena texto es de: " + contvo);
                    Console.WriteLine("El número de consonantes en la cadena texto es de: " + contcons);
                    break;
            }
            break;
        case 4:
            Console.WriteLine("Seleccione una opción: \n1.Calcular el área de un triángulo. \n2.Calcular el volumen de una esfera. \n3.Calcule la distancia entre dos puntos. \n4.Cacular la temperatura en Fahrenheit a partir de Celsius. \n5.Cacular la temperatura en Celsius a partir de Fahrenheit. ");
            op4 = int.Parse(Console.ReadLine());

            switch (op4)
            {
                case 1:
                    Console.WriteLine("Ingrese la base del triángulo: ");
                    double baT = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triángulo: ");
                    double alT = double.Parse(Console.ReadLine());
                    double arT = (baT * alT) / 2;
                    Console.WriteLine("El área del triángulo es de: " + arT);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el radio de la esfera: ");
                    double ra = double.Parse(Console.ReadLine());
                    double vol = (4.0 * Math.PI * Math.Pow(ra, 3)) / 3;
                    Console.WriteLine("El volumen de la esfera es de: " + vol);
                    break;
                case 3:
                    Console.WriteLine("Ingrese las coordenadas en el plano cartesiano del primer punto (x1 y1): ");
                    double x1 = double.Parse(Console.ReadLine());
                    double y1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese las coordenadas en el plano cartesiano del segundo punto (x2 y2): ");
                    double x2 = double.Parse(Console.ReadLine());
                    double y2 = double.Parse(Console.ReadLine());
                    double dis = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                    Console.WriteLine("La distancia entre los puntos es de: " + dis);
                    break;
                case 4:
                    Console.WriteLine("Ingrese la temperatura en grados Celsius:");
                    double cel1 = double.Parse(Console.ReadLine());
                    double fah1 = (cel1 * (9 / 5)) + 32;
                    Console.WriteLine("La temperatura en grados Fahrenheit es de: " + fah1);
                    break;
                case 5:
                    Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
                    double fah2 = double.Parse(Console.ReadLine());
                    double cel2 = (fah2 - 32) * (5 / 9);
                    Console.WriteLine("La temperatura en grados Celsius es de: " + cel2);
                    break;
            }

            break;
    }
} while (opp !=5);
Console.WriteLine("Good Bye");