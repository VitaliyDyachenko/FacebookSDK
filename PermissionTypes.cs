using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IX;

namespace FacebookSDK
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Values that represent permission types. </summary>
    ///
    /// <author>    Anwar Javed. </author>
    /// <date>  7:30 PM 06 May 2015. </date>
    ///-------------------------------------------------------------------------------------------------

    public enum PermissionTypes
    {
        /// <summary>   Provides access to a subset of items that are part of a person's public profile. </summary>
        [Description("public_profile")]
        Profile,


        /// <summary>   Provides access the list of friends that also use your app. </summary>
        [Description("user_friends")]
        Friends,


        /// <summary>  Provides access to the person's primary email address via the email property on the user object. </summary>
        [Description("email")]
        Email,


        /// <summary>   Provides access to a person's personal description (the 'About Me' section on their Profile) through the bio property on the User object. </summary>
        [Description("user_about_me")]
        AboutMe,


        /// <summary>   Provides access to all common books actions published by any app the person has used. This includes books they've read, want to read, rated or quoted. </summary>
        [Description("user_actions.books")]
        Books,


        /// <summary>   Provides access to all common Open Graph fitness actions published by any app the person has used. This includes runs, walks and bikes actions. </summary>
        [Description("user_actions.fitness")]
        Fitness,

        /// <summary>   Provides access to all common Open Graph music actions published by any app the person has used. This includes runs, walks and bikes actions. </summary>
        [Description("user_actions.music")]
        Music,

        /// <summary>   Provides access to all common Open Graph news actions published by any app the person has used. This includes runs, walks and bikes actions. </summary>
        [Description("user_actions.news")]
        News,

        /// <summary>   Provides access to all common Open Graph video actions published by any app the person has used. This includes runs, walks and bikes actions. </summary>
        [Description("user_actions.video")]
        Video,


        /// <summary>   Access the date and month of a person's birthday. This may or may not include the person's year of birth, dependent upon their privacy settings and the access token being used to query this field.</summary>
        [Description("user_birthday")]
        Birthday,


        /// <summary>   Provides access to a person's education history through the education field on the User object. </summary>
        [Description("user_education_history")]
        EducationHistory,


        /// <summary>   Provides read-only access to the Events a person is hosting or has RSVP'd to. </summary>
        [Description("user_events")]
        Events,


        /// <summary>   Provides access to read a person's game activity (scores, achievements) in any game the person has played. </summary>
        [Description("user_games_activity")]
        Games,


        /// <summary>   Enables your app to read the Groups a person is a member of through the groups edge on the User object. </summary>
        [Description("user_groups")]
        Groups,


        /// <summary>  Provides access to a person's hometown location through the hometown field on the User object. This is set by the user on the Profile. </summary>
        [Description("user_hometown")]
        Hometown,


        /// <summary>   Provides access to the list of all Facebook Pages and Open Graph objects that a person has liked. This list is available through the likes edge on the User object. </summary>
        [Description("user_likes")]
        Likes,


        /// <summary>   Provides access to a person's current city through the location field on the User object. The current city is set by a person on their Profile. </summary>
        [Description("user_location")]
        City,


        /// <summary>   Enables your app to read the Groups a person is an admin of through the groups edge on the User object. </summary>
        [Description("user_managed_groups")]
        ManagedGroups,


        /// <summary>   Provides access to the photos a person has uploaded or been tagged in. This is available through the photos edge on the User object. </summary>
        [Description("user_photos")]
        Photos,


        /// <summary>   Provides access to the posts on a person's Timeline. Includes their own posts, posts they are tagged in, and posts other people make on their Timeline. </summary>
        [Description("user_posts")]
        Posts,


        /// <summary>   Provides access to a person's relationship status, significant other and family members as fields on the User object. </summary>
        [Description("user_relationships")]
        Relationships,


        /// <summary>   Provides access to a person's relationship interests as the interested_in field on the User object. </summary>
        [Description("user_relationship_details")]
        RelationshipDetails,


        /// <summary>   Provides access to a person's religious and political affiliations. </summary>
        [Description("user_religion_politics")]
        ReligionPolitics,


        /// <summary>   Provides access to a person's statuses. These are posts on Facebook which don't include links, videos or photos. </summary>
        [Description("user_status")]
        Status,


        /// <summary>   Provides access to the Places a person has been tagged at in photos, videos, statuses and links. </summary>
        [Description("user_tagged_places")]
        TaggedPlaces,


        /// <summary>   Provides access to the videos a person has uploaded or been tagged in. </summary>
        [Description("user_videos")]
        Videos,


        /// <summary>  Provides access to the person's personal website URL via the website field on the User object. </summary>
        [Description("user_website")]
        Website,


        /// <summary>   Provides access to a person's work history and list of employers via the work field on the User object. </summary>
        [Description("user_work_history")]
        WorkHistory,


        /// <summary>   Provides access to the names of custom lists a person has created to organize their friends. This is useful for rendering an audience selector when someone is publishing stories to Facebook from your app. </summary>
        [Description("read_custom_friendlists")]
        Friendlist,


        /// <summary>   Provides read-only access to the Insights data for Pages, Apps and web domains the person owns. </summary>
        [Description("read_insights")]
        Insights,

        /// <summary>  Provides the ability to read from the Page Inboxes of the Pages managed by a person. This permission is often used alongside the manage_pages permission. </summary>
        [Description("read_page_mailboxes")]
        PageMailbox,


        /// <summary>   Enables your app to retrieve Page Access Tokens for the Pages and Apps that the person administrates. </summary>
        [Description("manage_pages")]
        ManagePages,


        /// <summary>   When you also have the manage_pages permission, gives your app the ability to post, comment and like as any of the Pages managed by a person using your app. </summary>
        [Description("publish_pages")]
        PublishPages,


        /// <summary>   Provides access to publish Posts, Open Graph actions, achievements, scores and other activity on behalf of a person using your app. </summary>
        [Description("publish_actions")]
        PublishActions,


        /// <summary>   Provides the ability to set a person's attendee status on Facebook Events (e.g. attending, maybe, or declined). </summary>
        [Description("rsvp_event")]
        UpdateEvent,


    }
}
