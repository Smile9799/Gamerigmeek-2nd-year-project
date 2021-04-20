using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GameRigService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class Service2 : IService2
    {
        UserTableLinkDataContext db = new UserTableLinkDataContext();

        public int AddMember(User u)
        {
            var member = new UserTable
            {
                FirstName = u.name,
                LastName = u.lastname,
                EmailAd = u.email,
                CellNumber = u.phonenumber,
                Password = Secrecy.HashPassword(u.password),
                active= u.active,
                Usertype = u.usertype
              
            };
            db.UserTables.InsertOnSubmit(member);
            try
            {
                db.SubmitChanges();
                return 1;

            }
            catch (Exception e)
            {
                e.GetBaseException();
                return -1;
            }
        }

        public int AddSubscriber(NewsLetter Nlet)
        {
            var Submember = new NewsLetterTable
            {
                EmailAdrress = Nlet.EmailAd

            };
            db.NewsLetterTables.InsertOnSubmit(Submember);
            try
            {
                db.SubmitChanges();
                return 1;

            }
            catch (Exception e)
            {
                e.GetBaseException();
                return -1;
            }
        }

        public User GetUser(int ID)
        {
            var FoundUser = (from u in db.UserTables
                             where u.UserId.Equals(ID)
                             select u).FirstOrDefault();
            User us = new User
            {
                id = FoundUser.UserId,
                name = FoundUser.FirstName,
                lastname = FoundUser.LastName,
                email = FoundUser.EmailAd,
                password=FoundUser.Password,
                active=1,
                phonenumber=FoundUser.CellNumber,
                usertype = FoundUser.Usertype

            };
            return us;
        }

        public int AddNewProduct(string ProductName,int ProductPrice,string Colour,string Quantity,string type,string Description,string image)
        {
            var NewProduct = new ProductTable
            {
                ProductName = ProductName,
                Price = ProductPrice,
                Colour = Colour,
                Quantity = Quantity,
                Desc = Description,
                Type= type,
                ImgUrl =image
            };

            db.ProductTables.InsertOnSubmit(NewProduct);

            try
            {
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }

        }

        public bool EditProduct(AddProduct add, int Id)
        {
            var partId = (from d in db.ProductTables
                          where d.ProductId.Equals(Id)
                          select d).FirstOrDefault();
            partId.ProductName = add.name;
            partId.Price = add.price;
            partId.Quantity = add.Quant;
            partId.Colour = add.Col;
            partId.Colour = add.desc;
            partId.ImgUrl = add.imgurl;
            partId.Type = add.type;

            try
            {
                db.SubmitChanges();
                return true;
            }catch(IndexOutOfRangeException es)
            {
                es.GetBaseException();
                return false;
            }
        }

        public AddProduct GetProduct(int id)
        {
            var partId = (from d in db.ProductTables
                          where d.ProductId.Equals(id)
                          select d).FirstOrDefault();
            AddProduct member = new AddProduct
            {
                name=partId.ProductName,
                price= partId.Price,
                Col=partId.Colour,
                Quant=partId.Quantity,
                imgurl=partId.ImgUrl,
                desc=partId.Desc,
                type=partId.Type
            };
            return member;
        }

        public int Login(string EmailS, string PassWordS)
        {
            var check = (from d in db.UserTables
                         where d.EmailAd.Equals(EmailS) &&
                        d.active.Equals(1) &&
                         d.Password.Equals(Secrecy.HashPassword(PassWordS))
                         select d).FirstOrDefault();
            if (check != null)
            {
                return check.UserId;
            }
            else
            {
                return 0;
            }
        }

        public int SearchProduct(int id)
        {
            var check = (from d in db.ProductTables
                         where d.ProductId.Equals(id)
                         select d).FirstOrDefault();
            if (check != null)
            {
                return check.ProductId;
            }
            else
            {
                return -1;
            }
        }

        public bool Registerd (string email, string password)
        {
            dynamic check = (from R in db.UserTables
                             where R.EmailAd.Equals(email)
                             && R.Equals(Secrecy.HashPassword(password))
                             select R).FirstOrDefault();
            if (check != null)
            {
                return true;
            }
            else return false;

        }

        public List<ProductTable> searchProducts(string name)
        {
            var searchall = new List<ProductTable>();
            dynamic search = (from s in db.ProductTables
                              where s.ProductName.Equals(name)
                              orderby s.Price ascending 
                              select s).FirstOrDefault();
            foreach(ProductTable pt in search)
            {
                searchall.Add(pt);
            }
            return searchall;
        }
        public int DeleteProduct(int id)
        {
            var check = (from d in db.ProductTables
                         where d.ProductId.Equals(id)
                         select d).FirstOrDefault();

            db.ProductTables.DeleteOnSubmit(check);

            try
            {
                db.SubmitChanges();
                return 1;

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }

        }

        public List<ProductTable> getAllProducts()
        {
            var Allproducts = new List<ProductTable>();
            dynamic prod = (from p in db.ProductTables
                            select p);

            foreach(ProductTable pr in prod)
            {
                Allproducts.Add(pr);
            }
            return Allproducts;
        }

        public List<ProductTable> getAllFpProducts()
        {
            var Allproducts = new List<ProductTable>();
            dynamic prod = (from p in db.ProductTables
                            orderby p.Price ascending
                            select p);

            foreach (ProductTable pr in prod)
            {
                Allproducts.Add(pr);
            }
            return Allproducts;
        }

        public List<ProductTable> getAllFnProducts()
        {
            var Allproducts = new List<ProductTable>();
            dynamic prod = (from p in db.ProductTables
                            orderby p.ProductName ascending
                            select p);

            foreach (ProductTable pr in prod)
            {
                Allproducts.Add(pr);
            }
            return Allproducts;
        }

    

        public int DeleteUser(string email)
        {
            var u = (from p in db.UserTables where p.EmailAd.Equals(email) && p.active.Equals(1) select p).FirstOrDefault();


            db.UserTables.DeleteOnSubmit(u);

            try
            {
                db.SubmitChanges();

                return 1;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }
        }

        public int getProId(string name)
        {
            var check = (from d in db.ProductTables
                         where d.ProductName.Equals(name)
                         select d).FirstOrDefault();

           

          if(check != null)
            {
                return check.ProductId;
            }
            else
            {
                return 0;
            }
                

            
           

        }
    }
}
