using ChainOfResponsobolity.DAL.Entities;
using ChainOfResponsobolity.DAL;

namespace ChainOfResponsobolity.ChainOfResponsobilityDesignPattern
{
    public class AreaDirector : Employee
    {

        Context context = new Context();
        public override void ProcessRequest(WithDraw req)
        {
            if (req.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.EmployeeTitle = this.GetType().Name;
                customerProcess.EmployeeName = "Gizem Öztürk";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, müşteriye ödeme yapıldı";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.EmployeeTitle = this.GetType().Name;
                customerProcess.EmployeeName = "Gizem Öztürk";
                customerProcess.Description = "Limit Günlük Para Çekme Tutarını Aştığı için İşlem Onaylanamadı. ";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();            

            }
        }
    }
}