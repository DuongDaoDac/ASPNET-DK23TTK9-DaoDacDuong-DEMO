using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Suanha3.Models
{
    // Lớp cấu hình khởi tạo cơ sở dữ liệu
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<SuanhaDbContext>
    {
        // Phương thức Seed để thêm dữ liệu mẫu
        protected override void Seed(SuanhaDbContext context)
        {
            // Thêm dữ liệu mẫu cho bảng Services
            context.Services.Add(new Service { Name = "Sửa chữa điện nước", Description = "Sửa chữa và bảo trì hệ thống điện nước gia đình." });
            context.Services.Add(new Service { Name = "Chống thấm tường", Description = "Dịch vụ chống thấm tường và sàn nhà." });
            context.Services.Add(new Service { Name = "Thiết kế nội thất", Description = "Thiết kế và thi công nội thất hiện đại." });

            // Thêm dữ liệu mẫu cho bảng Contacts (nếu cần)
            context.Contacts.Add(new Contact
            {
                FullName = "Nguyễn Văn A",
                Email = "nguyenvana@example.com",
                Phone = "0123456789",
                Message = "Tôi cần sửa chữa nhà bếp."
            });

            // Lưu dữ liệu vào cơ sở dữ liệu
            context.SaveChanges();
        }
    }
}
