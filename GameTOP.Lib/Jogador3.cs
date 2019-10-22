using GameTOP.Interface;

namespace GameTOP.Lib
{

  public class Jogador3 : iJogador
  {
    public string Chuta()
    {
      return "Neymar estas pateando \n";
    }

    public string Corre()
    {
      return "Neymar estas corriendo \n";
    }

    public string Passe()
    {
      return "Neymar estas pasando \n";
    }
  }
}