import { Component } from '@angular/core';

@Component({
  selector: 'app-contact',
  standalone: true,
  imports: [],
  templateUrl: './contact.component.html',
  styleUrl: './contact.component.css'
})
export class ContactComponent {

    phoneNo:number = 909090;    
    email:string = 'someone@myorg.com';
    customerCare:number = 1800180098989494;


}
