import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ContactComponent } from "../components/contact/contact.component";

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [RouterOutlet, ContactComponent]
})
export class AppComponent {
  title = 'firstNGApp';

  appName:string = "First Angular App";
  teamSize:number = 15;
  developedBy:string = "Training Team";
  isAppLive:boolean = false;
  technologiesUsed:string[] = ['HTML','CSS','Typecript','Node','Bootstrap','REST'];



}
