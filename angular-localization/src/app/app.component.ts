import { Component } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { PageLayout } from 'src/Models/PageLayout';
import { LocaliztionService } from './Localiztion.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angular-localization';
  labels: any;
  isAuthorized: boolean = false;
  labelsKeys: string[] = [
    'UserName',
    'Password',
    'Login',
    'ShowHome'
  ];
  constructor(private localization: LocaliztionService){}
  ngOnInit(): void {
    this.getLayoutByKeys();
  }

  getLayoutByKeys(){
    this.localization.getlabelsByKeys(this.labelsKeys).subscribe(data=> this.labels = data);
  }


}
