using artistsMc.DB;
using artistsMc.Models;

namespace artistsMc.Services
{
  public class ArtistsService
  {
    internal List<Artist> Get()
    {
      return FakeDB.Artists;
    }

    internal Artist Get(string id)
    {
      Artist found = FakeDB.Artists.Find(a => a.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid ID");
      }
      return found;
    }

    internal Artist Create(Artist newArtist)
    {
      FakeDB.Artists.Add(newArtist);
      return newArtist;
    }

    internal void Remove(string id)
    {
      Artist artist = Get(id);
      FakeDB.Artists.Remove(artist);
    }

    internal Artist Update(Artist updatedArtist)
    {
      Artist oldArtist = Get(updatedArtist.Id);
      oldArtist.Name = updatedArtist.Name != null ? updatedArtist.Name : oldArtist.Name;
      return oldArtist;
    }
  }
}
