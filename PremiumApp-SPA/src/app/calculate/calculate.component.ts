import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import {Occupation} from '../Occupation';

@Component({
  selector: 'app-calculate',
  templateUrl: './calculate.component.html',
  styleUrls: ['./calculate.component.css']
})
export class CalculateComponent implements OnInit {
 
  model: any = {
   name: '',
   age: 0,
   dateofBirth: '',
   occupation : '',
   sumInsured : 0,
   premium: 0,
  };
  premium: any;

  calculating = true;

  occupation: Occupation[];
  occupationSelected: number;

  constructor(private authService: AuthService) { }

  ngOnInit() {
    this.occupation=[
      {id:1,name:'Select'},
      {id:2,name:'Cleaner'},
      {id:3,name:'Doctor'},
      {id:4,name:'Author'},
      {id:5,name:'Farmer'},
      {id:6,name:'Mechanic'},
      {id:7,name:'Florist'},
    ];
    this.occupationSelected = 1;
  }

  recalculatePremium(){
    console.log('abc');
  }

  calculate() {
    this.calculating = true;
    this.authService.calculate(this.model).subscribe((data) => {
      this.calculating = false;
      this.premium = data;
      this.model = data;      
      console.log(this.model);
      
    }, error => {
      console.log(error);
    });
  }

  recalculate()
  { 
    this.model.premium = 0;
    this.calculate();
  }

  calculateAge() {
    var birthDate = new Date(this.model.dateofBirth);
    let timeDiff = Math.abs(Date.now() - birthDate.getTime());
    let age = Math.floor((timeDiff / (1000 * 3600 * 24))/365.25);
    if (isNaN(age))
     age = 0;

    console.log('age');
    this.model.age = age;
  }


}
