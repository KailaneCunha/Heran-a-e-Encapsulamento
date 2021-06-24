using  System ;

namespace  Aula10
{
 programa de aula
{
    static  void  Main ( string [] args )
    {
        Console . WriteLine ( " Olá, mundo! " );

        Circulo  circ1  =  novo  Circulo ( 2.0 );
        
        // acessando métodos get
        Console . WriteLine ( " Raio: \ t \ t {0: 0.0} " , circ1 . Raio );
        Console . WriteLine ( " Área: \ t \ t {0: 0.0} " , circ1 . Área );
        Console . WriteLine ( " Perímetro \ t {0: 0.0} " , circ1 . Perimetro );

        // acessando o conjunto de método
        // atualização automática
        // da área e perímetro
        circ1 . Raio  =  3,0 ;
        
        // acessando métodos get
        Console . WriteLine ( " Raio: \ t \ t {0: 0.0} " , circ1 . Raio );
        Console . WriteLine ( " Área: \ t \ t {0: 0.0} " , circ1 . Área );
        Console . WriteLine ( " Perímetro \ t {0: 0.0} " , circ1 . Perimetro );

        // valor inválido sem conjunto de método
        circ1 . Raio  =  - 3,0 ;
        
        // acessando métodos get
        Console . WriteLine ( " Raio: \ t \ t {0: 0.0} " , circ1 . Raio );
        Console . WriteLine ( " Área: \ t \ t {0: 0.0} " , circ1 . Área );
        Console . WriteLine ( " Perímetro \ t {0: 0.0} " , circ1 . Perimetro );
    


        Retângulo   reta1   =   Novo   Ret â Ngulo ( 2,0 );
        
        // acessando métodos get
        
        Console . WriteLine ( " Área: \ t \ t {0: 0.0} " , reta1 . Á rea );
        Console . WriteLine ( " Perímetro \ t {0: 0.0} " , reta1 . Perimetro );

        // acessando o conjunto de método
        // atualização automática
        // da área e perímetro
        
        
        // acessando métodos get
        
        Console . WriteLine ( " Área: \ t \ t {0: 0.0} " , reta1 . Á rea );
        Console . WriteLine ( " Perímetro \ t {0: 0.0} " , reta1 . Perimetro );

        // valor inválido sem conjunto de método
   
        
        // acessando métodos get
      
        Console . WriteLine ( " Área: \ t \ t {0: 0.0} " , reta1 . Á rea );
        Console . WriteLine ( " Perímetro \ t {0: 0.0} " , reta1 . Perimetro );
    }




       

}
}
