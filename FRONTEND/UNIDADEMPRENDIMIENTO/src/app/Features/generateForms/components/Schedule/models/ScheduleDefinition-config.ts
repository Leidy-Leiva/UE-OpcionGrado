import { ScheduleRow } from "./SheduleRow-config";

export interface ScheduleDefinition {
  title: string;
  enunciado: string;
  startMonth: number;
  endMonth: number;
  rows: ScheduleRow[];
}