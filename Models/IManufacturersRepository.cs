using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturerApp.Models
{
    public interface IManufacturersRepository
    //인터페이스에 5개 메소드 구현
    {
        Task<Manufacturer> AddManufacturer(Manufacturer manufacturer); //입력
        Task<List<Manufacturer>> GetManufacturers(); //출력
        Task<Manufacturer> GetManufacturer(int id); //상세
        Task<Manufacturer> EditManufacturer(Manufacturer manufacturer); //수정
        Task Deletemanufacturer(int id); //삭제
    }
}

