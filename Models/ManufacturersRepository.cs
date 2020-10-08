using ManufacturerApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturerApp.Models
{
    public class ManufacturersRepository : IManufacturersRepository
    {
        private readonly ApplicationDbContext _context;

        public ManufacturersRepository(ApplicationDbContext context) //생성자만들기
        {
            this._context = context;
        }

        //입력 관련 비동기 메소드 
        public async Task<Manufacturer> AddManufacturer(Manufacturer manufacturer)
        {
            _context.Manufacturers.Add(manufacturer); //Manufacturers 테이블에 매게변수 manufacturer를 받아서 저장하자
            await _context.SaveChangesAsync(); //비동기저장
            return manufacturer;
        }

        //출력
        public async Task<List<Manufacturer>> GetManufacturers()
        {
            return await _context.Manufacturers.OrderBy(m => m.Id).ToListAsync(); //ToList
        }

        //상세보기
        public async Task<Manufacturer> GetManufacturer(int id)
        {
            //return await _context.Manufacturers.Where(m => m.Id == id).SingleOrDefaultAsync(); // SingleOrDefaultAsync???
            return await _context.Manufacturers.FindAsync(id); // SingleOrDefaultAsync???
        }

        //수정 
        public async Task<Manufacturer> EditManufacturer(Manufacturer manufacturer)
        {
            _context.Entry(manufacturer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return manufacturer;

        }

        //삭제
        public async Task Deletemanufacturer(int id)
        {
            //var manufacturer = await _context.Manufacturers.Where(m => m.Id == id).SingleOrDefaultAsync();
            var manufacturer = await _context.Manufacturers.FindAsync(id);
            if (manufacturer != null)
            {
                _context.Manufacturers.Remove(manufacturer);
                await _context.SaveChangesAsync();
            }


        }


    }
}

