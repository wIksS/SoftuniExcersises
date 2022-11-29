using Formula1.Core.Contracts;
using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula1.Core
{
    public class Controller : IController
    {
        private PilotRepository pilotRepository;
        private RaceRepository raceRepository;
        private FormulaOneCarRepository formulaOneCarRepository;

        public Controller()
        {
            pilotRepository = new PilotRepository();
            raceRepository = new RaceRepository();
            formulaOneCarRepository = new FormulaOneCarRepository();
        }

        public string CreatePilot(string fullName)
        {
            if (pilotRepository.FindByName(fullName) != null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.PilotExistErrorMessage, fullName));
            }
            IPilot pilot = new Pilot(fullName);

            pilotRepository.Add(pilot);
            return String.Format(OutputMessages.SuccessfullyCreatePilot, fullName);
        }


        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            if (formulaOneCarRepository.FindByName(model) != null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.CarExistErrorMessage, model));
            }
            IFormulaOneCar car = null;
            if (type == "Ferrari")
            {
                car = new Ferrari(model, horsepower, engineDisplacement);
            }
            else if (type == "Williams")
            {
                car = new Williams(model, horsepower, engineDisplacement);

            }
            else
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InvalidTypeCar, type));
            }

            formulaOneCarRepository.Add(car);
            return String.Format(OutputMessages.SuccessfullyCreateCar, type, model);
        }



        public string CreateRace(string raceName, int numberOfLaps)
        {
            if (raceRepository.FindByName(raceName) != null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.RaceExistErrorMessage, raceName));
            }
            IRace race = new Race(raceName, numberOfLaps);


            raceRepository.Add(race);
            return String.Format(OutputMessages.SuccessfullyCreateRace, raceName);
        }

        public string AddCarToPilot(string pilotName, string carModel)
        {
            IPilot pilot = pilotRepository.FindByName(pilotName);
            IFormulaOneCar car = formulaOneCarRepository.FindByName(carModel);
            if (pilot == null || pilot.Car != null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.PilotDoesNotExistOrHasCarErrorMessage, pilotName));
            }
            if (car == null)
            {
                throw new NullReferenceException(String.Format(ExceptionMessages.CarDoesNotExistErrorMessage, carModel));
            }

            pilot.AddCar(car);
            formulaOneCarRepository.Remove(car);
            string carType = car.GetType().Name;


            return String.Format(OutputMessages.SuccessfullyPilotToCar, pilotName, carType, carModel);
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            IRace race = raceRepository.FindByName(raceName);
            IPilot pilot = pilotRepository.FindByName(pilotFullName);
            if (race == null)
            {
                throw new NullReferenceException(String.Format(ExceptionMessages.RaceDoesNotExistErrorMessage, raceName));
            }
            if (pilot == null || pilot.CanRace == false || race.Pilots.Contains(pilot))
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.PilotDoesNotExistErrorMessage, pilotFullName));
            }

            race.AddPilot(pilot);

            return String.Format(OutputMessages.SuccessfullyAddPilotToRace, pilotFullName, raceName);
        }

        public string StartRace(string raceName)
        {
            IRace race = raceRepository.FindByName(raceName);

            if (race == null)
            {
                throw new NullReferenceException(String.Format(ExceptionMessages.RaceDoesNotExistErrorMessage, raceName));
            }
            if (race.Pilots.Count < 3)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InvalidRaceParticipants, raceName));
            }
            if (race.TookPlace)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.RaceTookPlaceErrorMessage, raceName));
            }

            List<IPilot> orderedPilots = race.Pilots.OrderByDescending(p => p.Car.RaceScoreCalculator(race.NumberOfLaps)).ToList();

            race.TookPlace = true;
            orderedPilots[0].WinRace();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pilot { orderedPilots[0].FullName } wins the {raceName} race.");
            sb.AppendLine($"Pilot { orderedPilots[1].FullName } is second in the {raceName} race.");
            sb.AppendLine($"Pilot { orderedPilots[2].FullName } is third in the {raceName} race.");

            return sb.ToString().Trim();

        }

        public string PilotReport()
        {
            List<IPilot> pilots = pilotRepository.Models.OrderByDescending(p=>p.NumberOfWins).ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var pilot in pilots)
            {
                sb.AppendLine(pilot.ToString());
            }

            return sb.ToString().Trim();
        }

        public string RaceReport()
        {
            List<IRace> races = raceRepository.Models.Where(r => r.TookPlace).ToList();
            StringBuilder sb= new StringBuilder();
            foreach (var race in races)
            {
                sb.AppendLine(race.RaceInfo());
            }

            return sb.ToString().Trim();
        }

    }
}
