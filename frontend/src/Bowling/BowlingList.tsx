import { Bowler } from '../types/Bowler';
import { useEffect, useState } from 'react';

// function for the bolwing list to display using state and effects as well as implementing the backend and ts files
function BowlingList() {
  const [bowlingData, setBowlingData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlingData = async () => {
      const rsp = await fetch('http://localhost:5260/Bowlingleague');
      const b = await rsp.json();
      setBowlingData(b);
    };
    fetchBowlingData();
  }, []);

  return (
    <>
      <div className="row">
        <h4>This is the Bowlers Info</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <td>Bowler Name:</td>
            <td>Team Name:</td>
            <td>Address:</td>
            <td>City:</td>
            <td>State:</td>
            <td>Zip:</td>
            <td>Phone Number:</td>
          </tr>
        </thead>
        <tbody>
          {bowlingData.map((b) => (
            <tr key={b.bowlerID}>
              <td>
                {b.bowlerFirstName} {b.bowlerMiddleInit} {b.bowlerLastName}
              </td>
              <td>{b.team.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlingList;
