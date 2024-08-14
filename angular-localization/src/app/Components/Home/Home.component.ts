import { Component, OnInit } from '@angular/core';
import { LocaliztionService } from 'src/app/Localiztion.service';

@Component({
  selector: 'app-Home',
  templateUrl: './Home.component.html',
  styleUrls: ['./Home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private localization: LocaliztionService) { }
  labels: any;
  labelsKeys: string[] = [
    'Title',
    'Description'
  ];

  ngOnInit() {
    this.getlabelsByKeys();
  }

  getlabelsByKeys(){
    this.localization.getlabelsByKeys(this.labelsKeys).subscribe(data=> this.labels = data);
  }


}
