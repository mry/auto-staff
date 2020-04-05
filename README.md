


# Autostaffer: Applying the Uber model for automated sick leave replacement

![AutoStaffer logo](https://drive.google.com/open?id=1eX1VW9PH3fTDzYvlFL9FbqD2i_Sxg4bf)

  

# Pitch
 We support the need to "flatten the curve" by increased protection of the elderly through automatic on-demand staffing for last minute sick leave replacement.

Autostaffer removes the manual effort to search for replacement staff, and it supplies ease of mind that the job will still be done if you stay home sick.

We are presenting an action plan that will make the solution available within six weeks using existing system providers as vehicle for the Autostaffer micro service that will sit on the edge of any staffing system and plug into any pool of workers.

![AutoStaffer Concept](https://drive.google.com/open?id=11M2TUaFPntfjMAW4UYpyOc_w4b5v8zpe)

# Problem
Together we need to flatten the curve by protecting the elderly. We need to be faster and more rigor when securing temporary staffing and avoid managers manual dialing-around to find available resources. It is imperative that staff stay home if they are showing symptoms of sickness, but this is increasing stress on the remaining staff creating an increased risk of cutting corners on protection.

Existing systems focus on scheduling existing staff but is struggling when staff does not show up with short notice. Although there exist several pools of volunteers or jobseekers, there is a need to make those resources available quickly and preferably on demand.

Sudden absence of staff is a problem for several parties; the HR administration needs to quickly ensure replacement, the staff calling in sick may feel uneasy about not stepping up, the replacement staff get called even when (s)he is unavailable.

In the end this leads to staff spending hours on the phone trying to backfill positions and, if failing, leaving individuals without the care they need. Ultimately loyal staff risk to show up even if they are sick and taking unnecessary risks in order to give care even if understaffed.

During our analysis we have identified 3 primary stakeholders. 1) Managers or HR Administrators (“Managers”) 2) Staff that needs to report sick (“Staff”) and 3) Pool of workers that can take on the job (“Workpool”). Below is a description on what they are trying to achieve, what the major gain would be from a potential solution and what pains they would like to avoid.

## Managers
The manager uses the solution to minimize the number of no-shows and instead of manually getting replacement staff for no-shows.

### Managers gains
* Automated
* Just in time
* Reduced gaps in staffing
* Optional access to larger pool of resources

### Managers pains
* Manual task
* Error Prone

## Staff
A Staffer is scheduled to show up at a specific time and needs to be able to report sick with very short notice.

### Staff gains
* Easy way to report sick.
* Feeling certain that it will be properly staffed
* Optional Feedback on status for backfill
* No need to remember who to call and at what number
* Optional assessment on if you should stay home or not (“How sick are you?)

### Staff pains
* Show up even if you are sick because of loyalty or fear of letting others down.
* Forgetting to show up (optional)
* Unsure if (s)he is sick or not

## Workpool
A Workpool needs access to jobs that are available to be able to maximize the benefit of the pool. The pool of workers needs a solution that enables them to schedule their availability, i.e. to be able to tell from time to time if they can or cannot take on an assignment.

### Workpool gains
* Make resources available directly when someone reports in sick
* Pull availability

### Workpool pains
* Several competing systems for hiring workers
* Need to constantly remind employers that one is available

## Other Stakeholders

### HR manager
The HR manager/Department needs to ensure that they have the correct data on staffing to ensure compliance to regulations and make correct salary payments. Over time HR is also interested in getting statistics and data from the solution.

HR managers are interested in tapping in to additional resource pools to mitigate increasing sick leave. This is not an urgent staffing need, but rather a long term resource provision.

### Staffing agencies, Volunteer networks and “Arbetsförmedlingen”
Staffing agencies will be interested in promoting their staff as back-fill and might also in turn be interested in using the solution for their own staff.

## Prioritization and initial scope

### Proof of Concept

Since time is of essence, we suggest prioritizing in a rapid Proof of Concept that can verify:
1. Ease of integration to employer systems
2. User Experience using the application
3. Basic Technical framework

### 1 month vision
We estimate that a working solution also needs to include:
1. Assessment and alignment with labour laws
2. General law, rules and regulations (such as GDPR etc)
3. Implementation of work category standards (e.i.e SSYK)
4. Integration to at least 3 major resource platforms
5. Integration to at least 3 major resource planning tools

### 2 month additions
If successful the solution should be able to extend with:
1. Segments (hotels, restaurants, warehouse etc)
2. Markets/countries
3. Additional features for statistical analysis
4. Features for pre-vetting of staff to ensure the right skill-set etc.
5. Betting functionality to increase pay for non-attractive or risky assignments

## References
Due to the relative short timeframe and weekend availability we have only conducted a limited set of interviews to assert the problem statement. A big __Thank You!__ to:
* TempusInfo CEO **Joel Hörnqvist**
* Lund Municipality **Inesa Fejzic** and **Eva Mårtensson Carlsson**
* City of Lund **Johan Ljungström**
* FRISQ **Casper Winsnes** 

# Solution
//TBD
* Uber for replacement (crisis staffing)
* Capacity on tap

![Autostaffer Detailed Concept](https://drive.google.com/open?id=1dzUgNa7L4PEUQPntyiqfkJQRVndpmwxJ)

# Action Plan
During the **HacktheCrisis** event, we have designed the basic concept and validated the idea using a generic technical framework. In order for the solution to be put in production we suggest a small core team (UX/frontend, backend and sales/coordination) of four people.
1. Ramp-up, revisit and detail scoping (1 week)
>This includes ramping up the team, create detail plans and go-to market plus and establish a pro

2. Finalize Minimal Viable Product (MVP) (2 weeks)
>Finalize and hardening the solution to production grade

4. Security testing and hardening of solution (2 weeks, 1 week parallel w. #2)
>The Micro service needs to be secured and CI/CD model implemented. We estimate this to be a two-week assignment for a team of four (backend, frontend, UX and coach)

5. Integration with major resource platforms (2 weeks)
>We estimate a 1-2-week work to find an negotiate with existing work platforms, maybe starting with "Arbetsförmedlingen" that has an existing API.

6. Integration to at least 3 major resource planning tools (2 weeks parallel w #3)
>We estimate a 1-2-week work to find an negotiate with existing work platforms, maybe starting with one of the major platforms that has an existing API.

7. Business development (parallel task for 6 weeks)
>This includes creating training documentation and planning for roll-out as well as assessment and alignment with general and labor laws, rules and regulations (such as GDPR etc.)

**Summary:** We think a realistic estimate to full production is 6 weeks with an effort of 24 weeks of FTE labor. Major risks in this is the availability of resources, and lack of acceptance from the end users. We are currently investigating if any of the major resource platform providers are prepared to sponsor with this with resources and we think that if the micro service is inluded in the already existing HR staffing system as a module, it would make it easier to accept for end users.

# Demo Video
// Separately

# Tech Description


// TBD

# Github repo
<https://github.com/mry/auto-staff](https://github.com/mry/auto-staff>

# Team Description
**Mattias Rylander** Product Owner (Ideation)
**Berulv Tøndel** Team Member (Agile coaching/Strategy/Design/Marketing)
**Martin Koch** Team Member (Business Development)
**Johan Nicklasson** Developer (API design, ux/ui, frontend/fullstack)
**Marius Cotor** Developer (Developer, Backend, API .Net)
**Nikolas Kartalidis** Developer (UI/UX specialist)

# Team Contact details
**Mattias Rylander** <mailto://mattias.rylander@gmail.com>, +46707863985
**Berulv Tøndel** <mailto://berulv.tondel@comprend.com]>, +46761090528
**Martin Koch** <mailto://martin.koch@mokan.tech>, +46761168937
**Johan Nicklasson** <mailto://[nicklasson_johan@hotmail.com>
**Marius Cotor** <mailto://cotor_m@yahoo.com>
**Nikolas Kartalidis** <mailto://kartalidis@gmail.com>,+46704753804
