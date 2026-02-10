/*CREATE TABLE inventory_tags (
inventario_id INT,
tags_id INT,
FOREIGN KEY(inventario_id) REFERENCES inventory(id),
FOREIGN KEY(tags_id) REFERENCES tags(id);
);