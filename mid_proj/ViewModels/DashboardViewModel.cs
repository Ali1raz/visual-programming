using mid_proj.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

public class DashboardViewModel : ViewModelBase
{
    public ObservableCollection<Student> Students { get; } = new ObservableCollection<Student>();
    public ObservableCollection<Teacher> Teachers { get; } = new ObservableCollection<Teacher>();

    public ICommand AddStudentCommand { get; }
    public ICommand DeleteStudentCommand { get; }

    public DashboardViewModel()
    {
        AddStudentCommand = new RelayCommand(_ => AddStudent());
        DeleteStudentCommand = new RelayCommand(DeleteStudent);
    }

    private void AddStudent()
    {
        Students.Add(new Student { Id = Students.Count + 1, Name = "New Student", Grade = "A" });
    }

    private void DeleteStudent(object obj)
    {
        if (obj is Student student)
            Students.Remove(student);
    }
}