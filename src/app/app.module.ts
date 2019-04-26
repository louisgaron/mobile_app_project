import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';

import { MyApp } from './app.component';
import { HomePage } from '../pages/home/home';
import {DestinationsPage} from '../pages/destinations/destinations';
import {ContactUsPage} from '../pages/contact-us/contact-us';
import {PhilippinesPage} from '../pages/philippines/philippines';
import {MaldivesPage} from '../pages/maldives/maldives';
import {BudapestPage} from '../pages/budapest/budapest';

@NgModule({
  declarations: [
    MyApp,
    HomePage,
    DestinationsPage,
    ContactUsPage,
    PhilippinesPage,
    MaldivesPage,
    BudapestPage
  ],
  imports: [
    BrowserModule,
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    HomePage,
    DestinationsPage,
    ContactUsPage,
    PhilippinesPage,
    MaldivesPage,
    BudapestPage

  ],
  providers: [
    StatusBar,
    SplashScreen,
    {provide: ErrorHandler, useClass: IonicErrorHandler}
  ]
})
export class AppModule {}
