import { Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { AboutComponent } from './components/about/about.component';
import { ContactComponent } from './components/contact/contact.component';
import { HistoryComponent } from './components/history/history.component';
import { NewsComponent } from './components/news/news.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { ResendentialComponent } from './components/contact/addresses/resendential/resendential.component';
import { OfficeComponent } from './components/contact/addresses/office/office.component';
import { CollegeComponent } from './components/contact/addresses/college/college.component';
import { PermenantComponent } from './components/contact/addresses/permenant/permenant.component';

export const routes: Routes = [
    { path:'',component:HomeComponent},
    { path:'home',component:HomeComponent},
    { path:'about',component:AboutComponent},
    { path:'contact',component:ContactComponent,children:[        
        {path:'resendentials',component:ResendentialComponent},
        {path:'office',component:OfficeComponent},
        {path:'college',component:CollegeComponent},
        {path:'permenant',component:PermenantComponent},
    ]},
    { path:'history',component:HistoryComponent},
    { path:'news',component:NewsComponent},
    { path:'login',component:LoginComponent},
    { path:'register',component:RegisterComponent},

];
