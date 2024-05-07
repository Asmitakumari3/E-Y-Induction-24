import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-friends',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './friends.component.html',
  styleUrl: './friends.component.css'
})
export class FriendsComponent {

        // Primitive tyeps
        myName:string  = "Nikhil";
        totalFriends:number = 2000;

        //Primitive data Array
        bestFriends:string[] = ['Akshay','Rahul','Riddhi','Somy','Jitesh','Aksah','Sahil']

        //json object 
        bestFriendDetails:any = {
          name:'Sahil',
          friendsSince:'Childhood',
          email:'sahil@somewhere.com',
          mobile:90890809,
          instaid:'sahil_insta',
          fbId:'sahil_not_on_fb'
        }

        //json object array
        friendList:any[] =[
          {friendName:'Roshni',friendCity:'Mumbai',friendEmail:'roshni@gmail.com',insta:'roshni_invisible',fb:'roshni_fakeid'},
          {friendName:'sumit',friendCity:'Chennai',friendEmail:'sumit@gmail.com',insta:'sumit_invisible',fb:'sumit_fakeid'},
          {friendName:'sagar',friendCity:'Pune',friendEmail:'sagar@gmail.com',insta:'sagar_invisible',fb:'sagar_fakeid'},
          {friendName:'kashish',friendCity:'Goa',friendEmail:'kashnish@gmail.com',insta:'kashish_invisible',fb:'kashish_fakeid'},
          {friendName:'Roshan',friendCity:'Pune',friendEmail:'roshan@gmail.com',insta:'roshan_invisible',fb:'rosan_fakeid'},
          {friendName:'Mohan',friendCity:'Goa',friendEmail:'mohan@gmail.com',insta:'mohan_invisible',fb:'mohan_fakeid'},
          {friendName:'Anand',friendCity:'Mumbai',friendEmail:'anand@gmail.com',insta:'anand_invisible',fb:'anand_fakeid'},
        
        ]








}
