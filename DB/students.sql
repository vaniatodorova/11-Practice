CREATE TABLE `sys`.`majors` (
  `major_id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`major_id`),
  UNIQUE INDEX `major_id_UNIQUE` (`major_id` ASC));
  
CREATE TABLE `sys`.`subjects` (
  `subject_id` INT(11) NOT NULL AUTO_INCREMENT,
  `subject_name` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`subject_id`),
  UNIQUE INDEX `subject_id_UNIQUE` (`subject_id` ASC));

CREATE TABLE `sys`.`students` (
  `student_id` INT(11) NOT NULL AUTO_INCREMENT,
  `student_number` VARCHAR(12) NOT NULL,
  `student_name` VARCHAR(50) NOT NULL,
  `major_id` INT(11) NOT NULL,
  PRIMARY KEY (`student_id`),
  UNIQUE INDEX `student_id_UNIQUE` (`student_id` ASC),
  INDEX `major_id_idx` (`major_id` ASC),
  CONSTRAINT `major_id`
    FOREIGN KEY (`major_id`)
    REFERENCES `sys`.`majors` (`major_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
CREATE TABLE `sys`.`payments` (
  `payment_id` INT(11) NOT NULL AUTO_INCREMENT,
  `payment_date` DATE NOT NULL,
  `payment_amount` DECIMAL(8,2) NOT NULL,
  `student_id` INT(11) NOT NULL,
  PRIMARY KEY (`payment_id`),
  UNIQUE INDEX `payment_id_UNIQUE` (`payment_id` ASC),
  INDEX `student_id_idx` (`student_id` ASC),
  CONSTRAINT `student_id`
    FOREIGN KEY (`student_id`)
    REFERENCES `sys`.`students` (`student_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
CREATE TABLE `sys`.`agenda` (
  `student id` INT(11) NOT NULL,
  `subject id` INT(11) NOT NULL,
  PRIMARY KEY (`student id`, `subject id`),
  INDEX `subject idx` (`subject id` ASC),
  CONSTRAINT `student id`
    FOREIGN KEY (`student id`)
    REFERENCES `sys`.`students` (`student_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `subject_id`
    FOREIGN KEY (`subject id`)
    REFERENCES `sys`.`subjects` (`subject_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
    