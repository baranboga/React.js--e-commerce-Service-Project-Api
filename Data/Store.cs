namespace loginuser.Data;

public static class Store
{
    public static List<User> Users = new List<User>{
        new User{Id=1,Username="user1",FirstName="Fatih",LastName="Baytar"},
        new User{Id=2,Username="user2",FirstName="Fatih",LastName="Baytar"},
        new User{Id=3,Username="user3",FirstName="Fatih",LastName="Baytar"},
        new User{Id=4,Username="user4",FirstName="Fatih",LastName="Baytar"},
        new User{Id=5,Username="user5",FirstName="Fatih",LastName="Baytar"},
        new User{Id=6,Username="user6",FirstName="Fatih",LastName="Baytar"},
        new User{Id=7,Username="user7",FirstName="Fatih",LastName="Baytar"},
        new User{Id=8,Username="user8",FirstName="Fatih",LastName="Baytar"},
    };
    public static List<Product> Products = new List<Product>{
        new Product{Id=1,Name="Su arıtma Montajı",Description=" Su arıtma Montajı",Price=80,Image="https://images.pexels.com/photos/928854/pexels-photo-928854.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",value=1, Education="Merhaba ben Veli usta, Su artıma cihazları satıyorum"},
        new Product{Id=2,Name="İngilizce Öğretmeni",Description="İngilizce Öğretmeni",Price=100,Image="https://images.pexels.com/photos/5427998/pexels-photo-5427998.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",value=1, Education="Merhaba ben ayşe, üniversite öğrencisiyim boş zamanlarımda ingilizce öğretiyorum "},
        new Product{Id=3,Name="Yazılım kursu",Description="Modern javascript dersleri ile (ES6 & ES7+) Nodejs, Angular, React ve VueJs için sağlam bir temel oluşturun.(50 saat)",Price=120,Image="https://images.pexels.com/photos/614117/pexels-photo-614117.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",value=1,Education="Javascript dilini etkin bir şekilde kullanabileceksiniz. Ve en önemlisi NodeJs , Angular ,React ve VueJs ile uygulama geliştirebilecek bir alt yapıya sahip olacaksınız. ES5, ES6 ve ES7 arasındaki farklılıkları öğrenecek. Javascript ile Object Oriented Programlamayı, Prototype Yapısını ve ES6 Sınıflarını öğreneceksiniz."},
        new Product{Id=4,Name="Araç tamiri",Description="Araç tamiri",Price=300,Image="https://images.pexels.com/photos/279949/pexels-photo-279949.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",value=1,Education="Merhaba ben ömer usta 25 yıldır araç tamir ediyorum"},
        new Product{Id=5,Name="Yüzme Öğretmeni",Description="Yüzme Öğretmeni",Price=200,Image="https://images.pexels.com/photos/863988/pexels-photo-863988.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",value=1,Education="Merhaba ben ayşe, profesyonel yüzücüyüm ve yüzme eğitimi veriyorum"},
        new Product{Id=6,Name="Bahçivan", Description="Bahçivan", Price=350,Image="https://images.pexels.com/photos/2134798/pexels-photo-2134798.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",value=1,Education="Merhaba ben mustafa , bahçivanlık yapıyorum ve ağaçları çok seviyorum"},

    };
    public static List<Basket> Baskets = new List<Basket>{
        new Basket{Id=1,UserId=1,ProductId=1,Quantity=1},
        new Basket{Id=2,UserId=1,ProductId=2,Quantity=1},
        new Basket{Id=3,UserId=1,ProductId=3,Quantity=1}
    };

}