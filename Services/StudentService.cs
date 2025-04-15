using BlazorApp1.Model;
using System.Net.Http.Json;

namespace BlazorApp1.Services
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient _http;

        public StudentService(HttpClient http) => _http = http;

        public async Task<List<Student>> GetStudents() =>
            await _http.GetFromJsonAsync<List<Student>>("api/students/view-only");

        public async Task<Student> GetStudentById(int id) =>
            await _http.GetFromJsonAsync<Student>($"api/students/{id}");

        public async Task AddStudent(Student student) =>
            await _http.PostAsJsonAsync("api/students/admin/add", student);

        public async Task UpdateStudent(Student student) =>
            await _http.PutAsJsonAsync($"api/students/admin/edit/{student.Id}", student);

        public async Task DeleteStudent(int id) =>
            await _http.DeleteAsync($"api/students/admin/delete/{id}");

        public async Task ExportToExcel() =>
            await _http.GetAsync("api/students/export/excel");

        public async Task ExportToPDF() =>
            await _http.GetAsync("api/students/export/pdf");
    }

}
