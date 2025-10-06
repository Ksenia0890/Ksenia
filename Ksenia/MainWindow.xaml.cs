using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ksenia
{
    public partial class MainWindow : Window
    {
        private AppDbContext _context;

        public MainWindow()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadData();
        }

        private void LoadData()
        {
            PaymentsDataGrid.ItemsSource = _context.Payments.ToList();
            ServicesDataGrid.ItemsSource = _context.Services.ToList();
            EmployeesDataGrid.ItemsSource = _context.Employees.ToList();
            GuestsDataGrid.ItemsSource = _context.Guests.ToList();
            ReservationsDataGrid.ItemsSource = _context.Reservations.ToList();
        }

        // Пример метода для добавления платежа (можно создать UI для этого)
        private void AddPayment(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
            LoadData(); // Обновить данные после добавления
        }

        // Другие методы для редактирования и удаления записей можно реализовать аналогично.
    }
}
