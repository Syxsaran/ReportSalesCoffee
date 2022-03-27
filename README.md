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
classDiagram
  direction RL
  class Student {
    -idCard : IdCard
  }
  class IdCard{
    -id : int
    -name : string
  }
  class Bike{
    -id : int
    -name : string
  }
  Student "1" --o "1" IdCard : carries
  Student "1" --o "1" Bike : rides
**เจ้าของโปรแกรม**
```นาย ศรันย์ ซุ่นเส้ง```
