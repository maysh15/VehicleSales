import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { SalesDataUploadComponent } from './sales-data-upload/sales-data-upload.component';
import { SalesDataVisualizeComponent } from './sales-data-visualize/sales-data-visualize.component';

@NgModule({
  declarations: [
    AppComponent,
    SalesDataUploadComponent,
    SalesDataVisualizeComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: SalesDataUploadComponent, pathMatch: 'full' },
      { path: 'salesdatavisualize', component: SalesDataVisualizeComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
