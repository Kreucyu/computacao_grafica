using CG_Biblioteca;
using OpenTK.Graphics.OpenGL4;

namespace gcgcg
{
  internal class Circulo : Objeto
  {

    public Circulo(Objeto _paiRef, ref char _rotulo, double _raio) : base(_paiRef, ref _rotulo)
    {
      PrimitivaTipo = PrimitiveType.Points;
      PrimitivaTamanho = 5;

      for(int i = 0; i < 72; i++)
      {
        base.PontosAdicionar(Matematica.GerarPtosCirculo(i * 5, _raio));
      }

      Atualizar();
    }

    public void Atualizar()
    {

      base.ObjetoAtualizar();
    }

#if CG_DEBUG
    public override string ToString()
    {
      System.Console.WriteLine("__________________________________ \n");
      string retorno;
      retorno = "__ Objeto Circulo _ Tipo: " + PrimitivaTipo + " _ Tamanho: " + PrimitivaTamanho + "\n";
      retorno += base.ImprimeToString();
      return retorno;
    }
#endif

  }
}
