using csharp_net_course.Data;
using csharp_net_course.Models;

namespace csharp_net_course.Services
{
    public class SellerService
    {
        private readonly Csharp_net_courseContext _context;

        public SellerService(Csharp_net_courseContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(seller => seller.Id == id);
        }

        public void Remove(int id)
        {
            var seller = _context.Seller.Find(id);
            _context.Seller.Remove(seller);
            _context.SaveChanges();
        }
    }
}
