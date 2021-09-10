using Domain;

namespace Application.Repository.Interfaces
{
    public interface Movement
    {
        public Coordinates move(Coordinates coordinates);
    }
}