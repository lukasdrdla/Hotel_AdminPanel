using Hotel_AdminPanel.Domain.Entities;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_AdminPanel.Application.Services
{
    public class PdfService
    {
        //function to create pdf

        public void CreatePdf(List<Room> rooms)
        {
            //Create a new PDF document
            iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 10f, 10f, 10f, 10f);
            PdfWriter.GetInstance(document, new System.IO.FileStream("Rooms.pdf", System.IO.FileMode.Create));
            document.Open();

            //Add a title to the document
            Paragraph title = new Paragraph("Rooms");
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            //Create a table
            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 100;

            //Add headers to the table
            table.AddCell("Room Number");
            table.AddCell("Room Type");
            table.AddCell("Room Status");

            //Add data to the table
            foreach (var room in rooms)
            {
                table.AddCell(room.RoomNumber.ToString());
                table.AddCell(room.RoomType.Name);
                table.AddCell(room.RoomStatus.Name);
            }

            //Add the table to the document
            document.Add(table);

            //Close the document
            document.Close();
        }
    }
}
