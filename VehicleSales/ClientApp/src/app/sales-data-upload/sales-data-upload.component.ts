import { Component, OnInit } from '@angular/core';
import { UploadService } from '../services/upload.service';
import { VehicleMostSoldResult } from '../model/vehicle-most-sold-result.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sales-data-upload',
  templateUrl: './sales-data-upload.component.html',
  styleUrls: ['./sales-data-upload.component.css']
})
export class SalesDataUploadComponent implements OnInit {
  fileName: string;
  file: File = null;
  showresult: boolean = false;
  vehicleMostSoldResult: VehicleMostSoldResult
  constructor(private router: Router, private uploadService: UploadService) { }

  ngOnInit() {
  }

  selectFile(event) {
    this.file = event.target.files[0];
    this.fileName = this.file.name;
  }

  upload = () => {
    this.uploadService.uploadfile(this.file).subscribe((response: any) => {
      if (response) {
        if (response !== undefined && response["body"] !== undefined) {
          this.vehicleMostSoldResult = response["body"];
          this.showresult = true;
        }
      }
    });
  }

}
