import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import {PhilippinesPage} from './../philippines/philippines';
import {MaldivesPage} from './../maldives/maldives';
import {BudapestPage} from './../budapest/budapest';

/**
 * Generated class for the DestinationsPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@Component({
  selector: 'page-destinations',
  templateUrl: 'destinations.html',
})
export class DestinationsPage {

  constructor(public navCtrl: NavController, public navParams: NavParams) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad DestinationsPage');
  }

  philippines()
  {
    this.navCtrl.push(PhilippinesPage);
  }

  maldives()
  {
    this.navCtrl.push(MaldivesPage);
  }

  budapest()
  {
    this.navCtrl.push(BudapestPage);
  }


}
