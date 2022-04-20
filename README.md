# ReportSalesCoffee
**ความเป็นมาของโปรแกรม**
```
เนื่องจากในตอนเด็กผมอยากกิจการร้านกาแฟเล็กๆเป็นของตัวเอง ผมจึงสร้างโปรแกรมนี้ขึ้นมา
```
**วัตถุประสงค์ของโปรแกรม**
```
โปรแกรมนี้สร้างขึ้นเพื่อที่จะบันทึกว่าในเเต่ละวันมีการขายกาแฟและของหวานไปเท่าไหร่
```
**Class diagram**
```mermaid
classDiagram
  direction LR
  class form1{
  login()
  logout()
  }
  class logout{
  close()
  }
  class form2{
  -coffee
  -dessert
  logincoffee()
  logindessert()
  }
  class classcoffee{
  -number
  -name
  -amount
  -date
  add()
  }
  class classdessert{
  -number
  -name
  -amount
  -date
  add()
  }
    class classfood{
  -number
  -name
  -amount
  -date
  add()
  }
  class Filecoffee{
  -
  open()
  save()
  }
  class Filedessert{
  -
  open()
  save()
  }
  class Filefood{
  -
  open()
  save()
  }
  class opendessert{
  -location file
  open file()
  }
  class savedessert{
  -location file
  save file()
  }
  class opencoffee{
  -location file
  open file()
  }
  class savecoffee{
  -location file
  save file()
  }
  class openfood{
  -location file
  open file()
  }
  class savefood{
  -location file
  save file()
  }
  savecoffee --|> Filecoffee
  opencoffee --|> Filecoffee
  
  openfood --|> Filefood
  savefood --|> Filefood
  
  savedessert --|> Filedessert
  opendessert --|> Filedessert
  
  Filefood --|> classfood
  Filedessert --|> classdessert
  Filecoffee --|> classcoffee
  
  classfood --|> form2
  classcoffee --|> form2
  classdessert --|> form2
  
  form2 --|> form1
  logout --|> form1
  ```
**เจ้าของโปรแกรม**
```นาย ศรันย์ ซุ่นเส้ง```
