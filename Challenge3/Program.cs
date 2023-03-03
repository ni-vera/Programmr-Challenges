namespace Challenge3
{
    internal class Program
    {
        static string[] conv_unidades = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
        static string[] conv_decenas = { "","dieci", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
        static string Conversion_individual(int cifra,string nivel,int nivel_anterior = 0)
        {
            string convertido_indivual = "";
            switch (nivel)
            {
                case "unidad":
                    convertido_indivual = conv_unidades[cifra];
                    break;
                case "decena":
                    switch (cifra)
                    {
                        case 0:
                            break;
                        case 1:

                            switch (nivel_anterior)
                            {
                                case 0:
                                    convertido_indivual = "diez";
                                    break;
                                case 1:
                                    convertido_indivual = "once";
                                    break;
                                case 2:
                                    convertido_indivual = "doce";
                                    break;
                                case 3:
                                    convertido_indivual = "trece";
                                    break;
                                case 4:
                                    convertido_indivual = "catorce";
                                    break;
                                case 5:
                                    convertido_indivual = "quince";
                                    break;
                                default:
                                    convertido_indivual = "dieci";
                                    break;
                            }
                            break;
                        case 2:
                            convertido_indivual = "veinti";
                            break;
                        default:
                            convertido_indivual = conv_decenas[cifra] + " y ";
                            break;
                    }
                    break;
                case "centena":
                    switch (cifra)
                    {
                        case 1:
                            convertido_indivual = "ciento ";
                            break;
                        default:
                            if (cifra != 9)
                            {
                                convertido_indivual = Conversion_individual(cifra, "unidad") + "cientos ";
                            }
                            else
                            {
                                convertido_indivual = "novecientos ";
                            }
                            break;
                    }
                    break;
            }

            return convertido_indivual;
            }
        static string[] niveles = { "unidad", "decena", "centena" };
        static string Conversion_total(int numero_a_convertir)
        {
            string resultado_final = "";
            string numero_string = numero_a_convertir.ToString();
            int nivel_anterior = 0;
            if(numero_a_convertir >= 10 & numero_a_convertir<= 15)
            {
                resultado_final = Conversion_individual(1, "decena", int.Parse(numero_string[numero_string.Length - 1].ToString()));
            }
            else {
                for (int i = 0; i < numero_string.Length; i++)
                {
                    int cifra = int.Parse(numero_string[numero_string.Length - i - 1].ToString());
                    resultado_final = Conversion_individual(cifra, niveles[i], nivel_anterior) + resultado_final;
                    nivel_anterior = cifra;
                }
            }
            return(resultado_final);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca su número");
            int prueba = int.Parse(Console.ReadLine());
            string resultado = Conversion_total(prueba);
            if(resultado == "ciento ")
            {
                resultado = "cien";
            }
            char[] result_char = resultado.ToCharArray();
            result_char[0] = char.ToUpper(result_char[0]);
            resultado = string.Join("", result_char);
            Console.WriteLine(resultado);
        }
    }
}