using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Nro2_Lab3.Ej_D5
{
    class Cheque
    {
        //fields
        private int nroInterno;


        public int NroInterno //propiedad del campo
        {
            get { return nroInterno; }
            set { nroInterno = value; }
        }

        //Propiedades
        public string Banco
        { get; set; }     
        
        public decimal Importe
        { get; set; }
        public int Numero
        { get; set; }

        public string Propietario
        { get; set; }

        //métodos
        public void Guardar(int nroInterno, string banco, decimal importe, int numero, string propietario)
        {
            NroInterno = nroInterno;
            Banco = banco;
            Importe = importe;
            Numero = numero;
            Propietario = propietario;
        }

        public void Imprimir(int nroInterno, string banco, decimal importe, int numero, string propietario)
        {
            Console.WriteLine($"Numero interno: {nroInterno}");
            Console.WriteLine($"Banco: {banco}");
            Console.WriteLine($"Numero importe: {importe}");
            Console.WriteLine($"Numero: {numero}");
            Console.WriteLine($"Propietario: {propietario}");
        }

        public bool ValidarNroInterno(int nroInterno) {
            return (nroInterno > 100);

        }
    }
}
