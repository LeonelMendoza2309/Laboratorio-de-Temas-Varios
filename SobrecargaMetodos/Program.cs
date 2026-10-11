using System;
using static sobrecargado.SobreCargaMetodos;
        
SobreCarga varSobreCarga = new SobreCarga();
varSobreCarga.ProbarMetodosSobreCargados();
varSobreCarga.cuadrado(8);
Console.WriteLine("El cuadrado de {0}", varSobreCarga.cuadrado(9));