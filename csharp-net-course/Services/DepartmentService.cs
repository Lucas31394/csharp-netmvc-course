using csharp_net_course.Data;
using csharp_net_course.Models;

namespace csharp_net_course.Services
{
    public class DepartmentService
    {
        private readonly Csharp_net_courseContext _context;

        public DepartmentService(Csharp_net_courseContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(department => department.Name).ToList();
        }
    }
}
