using   System ;

namespace   Aula10
{
 classe pública Retângulo: Figura 
{
     
     Retangulo público ()
    {
        // escrita utilizando método set da propriedade
        ISSO. Raio = raio;
    }
    private   void   AtualizarArea ()
    {
        ISSO . _área   =   matem á tica . PI   *   isso . _raio   *   isso . _raio ;
    }
    private   void   AtualizarPerimetro ()
    {
        ISSO . _perimetro   =   2   *   Matem á tica . PI   *   isso . _raio ;
    }
}
}
