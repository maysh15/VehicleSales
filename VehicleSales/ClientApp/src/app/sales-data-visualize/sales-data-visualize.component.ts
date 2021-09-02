import { Component, OnInit, Input } from '@angular/core';
import { VehicleMostSoldResult } from '../model/vehicle-most-sold-result.model';
import { VehicleDeal } from '../model/vehicle-deal.model';

@Component({
  selector: 'app-sales-data-visualize',
  templateUrl: './sales-data-visualize.component.html',
  styleUrls: ['./sales-data-visualize.component.css']
})
export class SalesDataVisualizeComponent implements OnInit {
  @Input() vehicleMostSoldResult: VehicleMostSoldResult;
  lstVehicleDeal: VehicleDeal[];
  constructor() { }

  ngOnInit() {
    this.lstVehicleDeal = this.vehicleMostSoldResult.lstVehicleDeal
  }

}
