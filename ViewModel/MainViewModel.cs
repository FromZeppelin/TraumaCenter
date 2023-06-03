using System.Windows.Controls;
using System.Windows.Input;
using TraumaSoftware.View;

namespace TraumaSoftware.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        private Page TreaterView = new TreaterView();
        private Page CustomerView = new CustomerView();
        private Page CabinetView = new CabinetView();
        private Page MedcardView = new MedcardView();
        private Page SpecificationView = new SpecificationView();
        private Page DepartmentView = new DepartmentView();
        private Page BenefitView = new BenefitView();
        private Page TreatmentView = new TreatmentView();
        private Page PaymentView = new PaymentView();
        private Page _currentView = new TreaterView();

        public Page CurrentView { get => _currentView; set => Set(ref _currentView, value); }

        public ICommand OpenTreaterView { get { return new RelayCommand(open => CurrentView = TreaterView); } }
        public ICommand OpenCustomerView { get { return new RelayCommand(open => CurrentView = CustomerView); } }
        public ICommand OpenCabinetView { get { return new RelayCommand(open => CurrentView = CabinetView); } }
        public ICommand OpenMedcardrView { get { return new RelayCommand(open => CurrentView = MedcardView); } }
        public ICommand OpenSpecificationView { get { return new RelayCommand(open => CurrentView = SpecificationView); } }
        public ICommand OpenDepartmentView { get { return new RelayCommand(open => CurrentView = DepartmentView); } }
        public ICommand OpenBenefitView { get { return new RelayCommand(open => CurrentView = BenefitView); } }
        public ICommand OpenTreatmentView { get { return new RelayCommand(open => CurrentView = TreatmentView); } }
        public ICommand OpenPaymentView { get { return new RelayCommand(open => CurrentView = PaymentView); } }
    }
}
