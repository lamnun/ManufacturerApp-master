using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManufacturerApp.Models
{
    public interface IIdeaRepository
    {
        Task<Idea> AddIdea(Idea idea);
        Task<List<Idea>> GetIdeas();

        Task Deletemanuidea(int id);
    }
}
