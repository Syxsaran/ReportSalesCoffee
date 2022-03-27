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
  class open{
  -location file
  open file()
  }
  class save{
  -location file
  save file()
  }
  save --|> Filecoffee
  ```
**เจ้าของโปรแกรม**
```นาย ศรันย์ ซุ่นเส้ง```
