using artistsMc.Models;

namespace artistsMc.DB
{
  public static class FakeDB
  {
    public static List<Artist>? Artists { get; set; } = new List<Artist>(){
      new Artist("Van Gogh"),
      new Artist("Michael Jackson"),
      new Artist("Hunter Biden")
    };
  }
}