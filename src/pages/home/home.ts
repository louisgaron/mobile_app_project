import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import {DestinationsPage} from './../destinations/destinations';
import {ContactUsPage} from './../contact-us/contact-us';
@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  constructor(public navCtrl: NavController) {

  }
  homePage()
  {
    this.navCtrl.push(HomePage);
  }

  touristDestinations(){
    this.navCtrl.push(DestinationsPage);

 

  }
   contactUs()
  {
    this.navCtrl.push(ContactUsPage);
  }
}
