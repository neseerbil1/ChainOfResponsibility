using ChainOfResponsobolity.DAL;
using ChainOfResponsobolity.DAL.Entities;
using System.Xml.Linq;

namespace ChainOfResponsobolity.ChainOfResponsobilityDesignPattern
{
    public class Manager : Employee
    {
        Context context=new Context();
        public override void ProcessRequest(WithDraw req)
        {
            if (req.Amount <= 80000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.EmployeeTitle = this.GetType().Name;
                customerProcess.EmployeeName = "Ayşe Çınar";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, müşteriye ödeme yapıldı";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.EmployeeTitle = this.GetType().Name;
                customerProcess.EmployeeName = "Ayşe Çınar";
                customerProcess.Description = "Para Çekme Tutar Talebi Günlük İşlemi aştığı" +
                                "için talep bir üst personele yönlendirildi ";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);

            }
        }
}
}
