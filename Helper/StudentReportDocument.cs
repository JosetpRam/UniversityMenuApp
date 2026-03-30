using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.Helper
{
    public class StudentReportDocument : IDocument 
    {
        private readonly List<Student> _student;
        public StudentReportDocument(List<Student> student)
        {
            _student = student;
        }

        public void Compose(IDocumentContainer container) 
        {
            container.Page(page =>
            { 
                page.Margin(20);
                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                page.Footer().Element(ComposeFooter);

            });    
        }

        private void ComposeHeader(IContainer container)
        {
            container.Text("Reporte de Estudiantes")
                .FontSize(20)
                .Bold();
        }

        private void ComposeFooter(IContainer container)
        {
            container.Text(text =>
            {
                text.Span("Página ");
                text.CurrentPageNumber();
                text.Span(" de ");
                text.TotalPages();
            });
        }

        private void ComposeContent(IContainer container)
        {
            container.PaddingVertical(10).Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(50);
                    columns.RelativeColumn(3);
                    
                });
                
                table.Header(header =>
                {
                    header.Cell().Text("Id").Bold();
                    header.Cell().Text("Nombre").Bold();
                    
                });
                
                foreach (var student in _student)
                {
                    table.Cell().Text(student.Id.ToString());
                    table.Cell().Text(student.FullName);
                  
                }
            });
        }

    }
}
