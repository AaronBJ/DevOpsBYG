class InventoryModel {
  ID = 0
  DESCRIPTION = ''
  QUANTITY = 0
  IMAGE = ''

  constructor(ID, DESCRIPTION, QUANTITY, IMAGE) {
    this.ID = ID;
    this.DESCRIPTION = DESCRIPTION;
    this.QUANTITY = QUANTITY;
    this.IMAGE = IMAGE;
  }



}

var inventoryMockDataRecords = [];
inventoryMockDataRecords.push(new InventoryModel(0, "BRK 356 satinado", 1, "imagen"));
inventoryMockDataRecords.push(new InventoryModel(1, "BRK 420 cromado", 4, "imagen"));
inventoryMockDataRecords.push(new InventoryModel(2, "BRK 1364 negro", 9, "imagen"));
inventoryMockDataRecords.push(new InventoryModel(3, "BRK 1290 cromado", 5, "imagen"));
inventoryMockDataRecords.push(new InventoryModel(4, "BRK 670 negro", 7, "imagen"));
inventoryMockDataRecords.push(new InventoryModel(5, "GLR 612 satinado", 3, "imagen"));
inventoryMockDataRecords.push(new InventoryModel(6, "GLR 560 satinado", 1, "imagen"));
inventoryMockDataRecords.push(new InventoryModel(7, "GLR 290 cromado", 10, "imagen"));
inventoryMockDataRecords.push(new InventoryModel(8, "BRK 570 satinado", 12, "imagen"));
inventoryMockDataRecords.push(new InventoryModel(9, "GLR 420 negro", 19, "imagen"));

